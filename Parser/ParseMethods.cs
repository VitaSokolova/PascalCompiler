using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Parser.BodyNodes;
using CompilerConsole.Parser.CallNodes;
using CompilerConsole.Parser.VarNodes;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser {

    public partial class Parser {

        #region Constants

        private const string TypeDecl = "TYPE_DECL";
        private const string ArrDecl = "ARR_DECL";
        private const string ProcDecl = "PROC_DECL";
        private const string RefDecl = "var";
        private const string FuncCall = "FUNC_CALL";
        private const string ArrCall = "ARR_CALL";
        #endregion

        private List<VariableNode> ParseVarDecl(ITree tree, BodyNode bodyNode) {
            //Подразумевается, что нам сюда пришел itree = VAR_DECL

            List<VariableNode> variableNodesList = new List<VariableNode>();

            List<string> variableNames = new List<string>();
            for (int i = 0; i < tree.ChildCount; i++) {
                if (tree.GetChild(i).Text == TypeDecl) {

                    ITree typeDeclChild = tree.GetChild(i).GetChild(0);

                    if (typeDeclChild.Text == ArrDecl) {

                        #region Array declaration parsing

                        //Здесь typeDeclChild равен ARR_DECL
                        DataType type = this.StringToArrDataType(typeDeclChild.GetChild(1).GetChild(0).Text);
                        ITree range = typeDeclChild.GetChild(0); //здесь хранится узел Range

                        //Должны парситя выражения, но мы то знаем, что там целичисленные литералы (:
                        Literal leftSide = this.GetLiteralFromString(range.GetChild(0).Text);
                        Literal rightSide = this.GetLiteralFromString(range.GetChild(1).Text);

                        if (leftSide.DataType != DataType.VarInt || rightSide.DataType != DataType.VarInt) {
                            throw new InvalidCastException("Попытка присвоить разерности массива нецелочисленный размер");
                        }
                        int leftSize = (int) leftSide.Value;
                        int rightSize = (int) rightSide.Value;

                        if (leftSize < 0 && rightSize < 0) {
                            throw new InvalidCastException("Попытка присвоить разерности массива отрицательный размер");
                        }

                        foreach (var variableName in variableNames) {
                            variableNodesList.Add(new ArrNode(type, variableName, leftSize, rightSize));
                        }

                        #endregion

                    }
                    else {
                        //Здесь typeDeclChild равен какому-то типу данных
                        DataType type = this.StringToVarDataType(typeDeclChild.Text);
                        foreach (var variableName in variableNames) {
                            variableNodesList.Add(new StructVarNode(type, variableName));
                        }
                    }

                    variableNames.Clear();
                    continue;
                }
                else if (tree.GetChild(i).Text == RefDecl) {
                    var refargs = this.ParseVarDecl(tree.GetChild(i), bodyNode);
                    refargs.ForEach(node => node.IsReference = true);
                    variableNodesList.AddRange(refargs);
                    continue;
                }
                variableNames.Add(tree.GetChild(i).Text);
            }
            //Проверяем на повторение имен переменных
            foreach (var variableNode in variableNodesList) {
                var node = bodyNode.FindNodeByName<VariableNode>(variableNode.Name);
                if (node != null) {
                    throw new NodeExistException(
                        $"Переменная с именем {variableNode.Name} уже существует в текущем контексте");
                }
            }
            //Проверяем на то, повторяются ли переменные при объявлении
            foreach (var variableNode in variableNodesList) {
                var find = variableNodesList.Find(node => node.Name == variableNode.Name && !node.Equals(variableNode));

                if (find != null) {
                    throw new NodeExistException(
                        $"Переменная с именем {variableNode.Name} уже существует в текущем контексте");
                }
            }

            return variableNodesList;
        }


        private FuncNode ParseFuncDeclare(ITree tree, BodyNode bodyNode) {
            /*
             * 0 - имя
             * 1 - аргументы
             * 2 - возвращаемый тип (тело - для процедур)
             * 3 - тело (для функций)
             */
            //Ожидается tree = FUNC_DECL или PROC_DECL
            string name = tree.GetChild(0).Text;
            List<VariableNode> args;
            FuncNode funcNode;
            DataType returnType;
            //Сразу записываем тип
            if (tree.Text == ProcDecl) {
                returnType = DataType.Void;
                args = this.ParseVarDecl(tree.GetChild(1).GetChild(0), bodyNode);
                funcNode = new FuncNode(returnType, name, args, new Body());
                funcNode.ParentBodyNode = bodyNode;
                this.Parse(tree.GetChild(2), funcNode);
            }
            else {
                returnType = this.StringToVarDataType(tree.GetChild(2).GetChild(0).Text);
                funcNode = new FuncNode(returnType, name, new List<VariableNode>(), new Body());
                StructVarNode result = new StructVarNode(returnType, "result");
                funcNode.AddNode(result);
                funcNode.Args = this.ParseVarDecl(tree.GetChild(1).GetChild(0), bodyNode);
                funcNode.ParentBodyNode = bodyNode;
                this.Parse(tree.GetChild(3), funcNode);
                //Код проерки использование result раскоментить после добавления выражений
                bool resultDidUse = false;
                foreach (var node in funcNode) {
                    //здесь должен быть код провекри на использование переменной result
                    if (node is Expression && (node as Expression).LeftNode == result) {
                        resultDidUse = true;
                    }
                }
                if (!resultDidUse) {
                    throw new ArgumentException("В функции ни разу не было присвоино значение переменной result");
                }
            }
            return funcNode;
        }

        private Node ParseExpression(ITree tree, BodyNode bodyNode) {
            if (tree == null) {
                Console.WriteLine("OH MY GOD !!!!!!!!!!!!!!!!!");
                return null;
            }

            Literal lit = this.GetLiteralFromString(tree.Text);
            if (lit != null) {
                return lit;
            }

            if (tree.Text == FuncCall) {
                return this.ParseFuncCall(tree, bodyNode);
            }

            if (tree.Text == ArrCall) {
                return this.ParseArrCall(tree, bodyNode);
            }

            #region Expression

            if (this.IsExpr(tree.Text)) {
                ITree leftNode = tree.GetChild(0);
                ITree rightNode = tree.GetChild(1);
                Node left = this.ParseExpression(leftNode, bodyNode);
                Node right = null;

                if (rightNode != null) {
                    right = this.ParseExpression(rightNode, bodyNode);
                }

                if (left is ArrCall) {
                    (left as ArrCall).Assign = right;
                }

                ExprToken t = this.GetExpr(tree.Text);
                var expr = new Expression(left, right, t);

                if (!expr.IsValid) {
                    throw new Exception(
                        $"Произошла ошибка при разборе выражения {t} между типами {left.DataType} и {right.DataType}");
                }
                return expr;
            }

            #endregion

            #region Variable

            VariableNode variable = bodyNode.FindNodeByName<VariableNode>(tree.Text);

            if (variable == null) {
                throw new Exception(
                    $"Переменной с именем {tree.Text} не существует в текущем контексте ");
            }
            return variable;

            #endregion
        }

        private FuncCall ParseFuncCall(ITree tree, BodyNode bodyNode)
        {
            ITree methName = tree.GetChild(0);
            ITree args = tree.GetChild(1);

            FuncNode method = bodyNode.FindNodeByName<FuncNode>(methName.Text);

            if (method == null)
            {
                throw new Exception($"Метод с именем {methName.Text} не найден в текущем контексте");
            }
            List<Node> argList = new List<Node>();

            if (args != null)
            {
                for (int i = 0; i < args.ChildCount; i++)
                {
                    argList.Add(this.ParseExpression(args.GetChild(i), bodyNode));
                }

                if (argList.Count != method.Args.Count)
                {
                    throw new Exception($"Метод с именем {method.Name} содержит другое кол-во вргументов ");
                }

                for (int i = 0; i < argList.Count; i++)
                {
                    if (argList[i].DataType != method.Args[i].DataType)
                    {
                        throw new Exception($"Метод с именем {method.Name} не содержит аргументы с такими типами ");
                    }
                }
            }

            FuncCall call = new FuncCall(method);
            call.SendArgs = argList;

            return call;
        }

        private ArrCall ParseArrCall(ITree tree, BodyNode bodyNode)
        {
            ITree arrName = tree.GetChild(0);
            ITree callindex = tree.GetChild(1);

            var arrNode = bodyNode.FindNodeByName<ArrNode>(arrName.Text);

            if (arrNode == null)
            {
                throw new Exception($"Массив с именем {arrName.Text} не найден в текущем контексте");
            }

            ArrCall res = new ArrCall(arrNode);
            var tempIndex = this.ParseExpression(callindex, bodyNode);

            if (tempIndex.DataType != DataType.VarInt) {
                throw new Exception("Индекс массива должен быть целым числом");
            }
            res.Index = tempIndex;
            return res;
        }
    }
}
