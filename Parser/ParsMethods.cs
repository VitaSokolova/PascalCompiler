using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser {
    partial class Parser {
        private List<StructVariableNode> ParseVarDecl(ITree tree, Table table) {

            List<StructVariableNode> result = new List<StructVariableNode>();



            if (tree == null) {
                return result;
            }

            for (int i = 0; i < tree.ChildCount; i++) {
                List<string> variableNames = new List<string>();

                while (tree.GetChild(i).Text != "TYPE_DECL") {
                    variableNames.Add(tree.GetChild(i).Text);
                    i++;
                }

                string type = tree.GetChild(i).GetChild(0).Text;


                for (int j = 0; j < variableNames.Count; j++) {
                    if (Table.FindNode<StructVariableNode>(variableNames[j], table) != null) {
                        throw new NodeExistException($"Переменная {variableNames[j]} уже существует ");
                    }
                    Abstract.Type dataType = Expression.GetType(type);
                    if (dataType == Abstract.Type.Error)
                    {
                        throw new Exception($"Нет такого типа данных - {type}");
                    }
                    result.Add(new StructVariableNode(variableNames[j], dataType, "local"));
                }
            }

            return result;
        }

        private FuncNode ParseFuncProcDecl(ITree tree, Table table) {
            //Осталось проверить процедура это или функция и в соттветсвии с этим добавить возвращаемый тип и кое-чего еще дописать
            string name = tree.GetChild(0).Text;
           

            List<StructVariableNode> argList = new List<StructVariableNode>();
                //Получаем аргументы из метода
                ITree args = tree.GetChild(1);
                argList = this.ParseFuncProcArgs(args.GetChild(0), table);   

            //Нумеруем аргументы
            int count = 0;
            argList.ForEach((node) => { node.IdNumber = count++; });

            Table localTable = new Table(table);
            string type;

            //Если 3 аргумента, то это процедура
            if (tree.ChildCount == 3) {
                type = "void";

            }
            else {
                //Потому что RET_TYPE_SINGLE -> type
                type = tree.GetChild(2).GetChild(0).Text;
            }
            //Записываем аргументы в таблицу метода
            foreach (var node in argList) {
                localTable.list.Add(node);
            }

            //Вызываем парсинг тела метода
            // this.InitParser(tree.GetChild(tree.ChildCount - 1), localTable);
            Abstract.Type dataType = Expression.GetType(type);
            if (dataType == Abstract.Type.Error)
            {
                throw new Exception($"Нет такого типа данных - {type}");
            }
            FuncNode func = new FuncNode(name, dataType, localTable, argList);

            //if (tree.ChildCount == 4) {
            //    ITree declareVarDiv = tree.GetChild(2);
            //    IList<VariableNode> bodyVariables = this.ParseVarDecl(declareVarDiv, localTable);
            //    foreach (var bodyVariable in bodyVariables) {
            //        func.BodyTable.list.Add(bodyVariable);
            //        bodyVariable.Modificator = @"local";
            //    }
            //}

            foreach (var node in func.BodyTable.list) {
                foreach (var node1 in func.BodyTable.list) {
                    if (node == node1) {
                        continue;
                    }

                    if (node1.Name == node.Name) {
                        throw new NodeExistException($"Переменная с именем {node1.Name} уже существует в аргументах");
                    }
                }
            }

            table.list.Add(func);
            return func;
        }

        private List<StructVariableNode> ParseFuncProcArgs(ITree tree, Table upperTable) {
            if (tree == null) {
                return new List<StructVariableNode>();
            }

            List<StructVariableNode> argListForStruct = new List<StructVariableNode>();
            List<StructVariableNode> argListForRef = new List<StructVariableNode>();
            List<string> variableNamesForStruct = new List<string>();
            List<string> variableNamesForRef = new List<string>();
            for (int i = 0; i < tree.ChildCount; i++) {
                //Обход по всем потомкам VAR_DECL
                //Может быть несколько вариантов. Либо Var либо имя переменной
                if (tree.GetChild(i).Text == "var") {
                    var nodes = this.ParseVarDecl(tree.GetChild(i), table);
                    int ci = 0;
                    foreach (var variableNode in nodes) {
                        variableNode.IdNumber = ci++;
                        variableNode.VarType = VarType.Reference;
                        argListForStruct.Add(variableNode);
                    }
                }
                else {
                    if (tree.GetChild(i).Text == "TYPE_DECL") {
                        string type = tree.GetChild(i).GetChild(0).Text;
                        Abstract.Type dataType = Expression.GetType(type);
                        if (dataType == Abstract.Type.Error) {
                            throw new Exception($"Нет такого типа данных - {type}");
                        }

                        foreach (var variableName in variableNamesForStruct) {
                            argListForStruct.Add(new StructVariableNode(variableName, dataType, "local"));
                        }
                    }
                    else {
                        variableNamesForStruct.Add(tree.GetChild(i).Text);
                    }
                }
            }
            return argListForStruct;
        }


        private FuncCall ParseFuncCall(ITree tree, Table table) {
            string funcName = tree.GetChild(0).Text;
            List<StructVariableNode> argsList = new List<StructVariableNode>();
            if (tree.ChildCount == 2) {
                ITree args = tree.GetChild(1);
                throw new NotImplementedException($"Сорян, но пока не написан парсинг аргументов. Ошибка в функции {funcName}");
            }

            FuncNode func = Table.FindNode<FuncNode>(funcName, table);
            if (func == null) {
                throw new DllNotFoundException($"Функции с именем {funcName} не существует");
            }

            if (func.Args.Count != argsList.Count) {
                throw new DllNotFoundException($"Функции с именем {funcName}. Не совпадает кол-во аргументов");
            }

            //Здесь должна быть проверка типов

            return new FuncCall(funcName, func.Type, func);
        }

    }
}

