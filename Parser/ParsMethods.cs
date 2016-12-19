using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Antlr.Runtime.Tree;

namespace CompilerConsole.Parser {
    partial class Parser {
        private List<VariableNode> ParseVarDecl(ITree tree, Table table) {
            List<VariableNode> result = new List<VariableNode>();
            for (int i = 0; i < tree.ChildCount; i++) {
                List<string> variableNames = new List<string>();

                while (tree.GetChild(i).Text != "TYPE_DECL") {
                    variableNames.Add(tree.GetChild(i).Text);
                    i++;
                }
                string type = tree.GetChild(i).GetChild(0).Text;
                for (int j = 0; j < variableNames.Count; j++) {
                    result.Add(new VariableNode(variableNames[j], type, "local"));
                }
            }

            return result;
        }

        private FuncNode ParseFuncProcDecl(ITree tree, Table table) {
            //Осталось проверить процедура это или функция и в соттветсвии с этим добавить возвращаемый тип и кое-чего еще дописать
            string name = tree.GetChild(0).Text;
           

            List<VariableNode> argList = new List<VariableNode>();
            if (tree.ChildCount == 3) {
                //Получаем аргументы из метода
                ITree args = tree.GetChild(1);
                argList = this.ParseFuncProcArgs(args.GetChild(0), table);   
            }

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
            this.InitParser(tree.GetChild(tree.ChildCount - 1), localTable);

            FuncNode func = new FuncNode(name, type, localTable, argList);

            if (tree.ChildCount == 4) {
                ITree declareVarDiv = tree.GetChild(2);
                IList<VariableNode> bodyVariables = this.ParseVarDecl(declareVarDiv, table);
                foreach (var bodyVariable in bodyVariables) {
                    func.BodyTable.list.Add(bodyVariable);
                    bodyVariable.Modificator = @"local";
                }
            }

            table.list.Add(func);
            return func;
        }

        private List<VariableNode> ParseFuncProcArgs(ITree tree, Table upperTable) {
            List<VariableNode> argList = new List<VariableNode>();
            List<string> variableNames = new List<string>();
            for (int i = 0; i < tree.ChildCount; i++) {
                //Обход по всем потомкам VAR_DECL
                //Может быть несколько вариантов. Либо Var либо имя переменной
                if (tree.GetChild(i).Text == "var") {
                    var nodes = this.ParseVarDecl(tree.GetChild(i), table);
                    int ci = 0;
                    foreach (var variableNode in nodes) {
                        variableNode.IdNumber = ci++;
                        argList.Add(variableNode);
                    }
                }
                else {
                    if (tree.GetChild(i).Text == "TYPE_DECL") {
                        string type = tree.GetChild(i).GetChild(0).Text;

                        foreach (var variableName in variableNames) {
                            Node temp = Table.FindNode<VariableNode>(variableName, upperTable);
                            if (temp == null) {
                                throw new DataException($"Отсутствует переменная с именем {variableName}");
                            }
                            argList.Add(new VariableNode(temp.Name, temp.Type, "local"));
                        }
                    }
                    else {
                        variableNames.Add(tree.GetChild(i).Text);
                    }
                }
            }
            return argList;
        }


        private FuncCall ParseFuncCall(ITree tree, Table table) {
            string funcName = tree.GetChild(0).Text;
            List<VariableNode> argsList = new List<VariableNode>();
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

