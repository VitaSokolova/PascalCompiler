using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Antlr.Runtime.Tree;

namespace CompilerConsole.Parser
{
    partial class Parser
    {
        private List<VariableNode> ParseVarDecl(ITree tree, Table table)
        {
            List<VariableNode> result = new List<VariableNode>();
            for (int i = 0; i < tree.ChildCount; i++)
            {
                List<string> variableNames = new List<string>();

                while (tree.GetChild(i).Text != "TYPE_DECL")
                {
                    variableNames.Add(tree.GetChild(i).Text);
                    i++;
                }
                string type = tree.GetChild(i).GetChild(0).Text;
                for (int j = 0; j < variableNames.Count; j++)
                {
                    result.Add(new VariableNode(variableNames[j], type));
                }
            }

            return result;
        }

        private void ParseFuncProcDecl(ITree tree, Table table)
        {
            //Осталось проверить процедура это или функция и в соттветсвии с этим добавить возвращаемый тип и кое чего еще дописать
            string name = tree.GetChild(0).Text;
            ITree args = tree.GetChild(1);
            var argList = this.ParseFuncProcArgs(args.GetChild(0), table);
            Table localTable = new Table(table);
            string type;
            if (tree.ChildCount == 3)
            {
                type = "void";

            }
            else
            {
                type = tree.GetChild(2).GetChild(0).Text;
            }

            foreach (var node in argList)
            {
                localTable.list.Add(node);
            }

            this.InitParser(tree.GetChild(tree.ChildCount-1), localTable);

            FuncNode func = new FuncNode(name,type, localTable, argList);
            
            table.list.Add(func);
        }

        private List<VariableNode> ParseFuncProcArgs(ITree tree, Table upperTable)
        {
            List<VariableNode> argList = new List<VariableNode>();
            List<string> variableNames = new List<string>();
            for (int i = 0; i < tree.ChildCount; i++)
            {
                //Обход по всем потомкам VAR_DECL
                //Может быть несколько вариантов. Либо Var либо имя переменной
                if (tree.GetChild(i).Text == "var")
                {
                    var nodes = this.ParseVarDecl(tree.GetChild(i), table);
                    int ci = 0;
                    foreach (var variableNode in nodes)
                    {
                        variableNode.IdNumber = ci++;
                        argList.Add(variableNode);
                    }
                }
                else
                {
                    if (tree.GetChild(i).Text == "TYPE_DECL")
                    {
                        string type = tree.GetChild(i).GetChild(0).Text;

                        foreach (var variableName in variableNames)
                        {
                            Node temp = Table.FindNode<VariableNode>(variableName, upperTable);
                            if (temp == null)
                            {
                                throw new DataException($"Отсутствует переменная с именем {variableName}");
                            }
                            argList.Add(new VariableNode(temp.Name, temp.Type));
                        }
                    }
                    else
                    {
                        variableNames.Add(tree.GetChild(i).Text);
                    }
                }
            }
            return argList;
        }
    }
}

