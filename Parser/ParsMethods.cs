using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Antlr.Runtime.Tree;

namespace CompilerConsole.Parser
{
    partial class Parser
    {
        private void ParseVarDecl(ITree tree, Table table)
        {
            for (int i = 0; i < tree.ChildCount; i++)
            {
                List<string> variableNames = new List<string>();

                while (tree.GetChild(i).Text != "TYPE_DECL")
                {
                    variableNames.Add(tree.GetChild(i).Text);
                    i++;
                }
                string type = tree.GetChild(i).GetChild(0).Text;

                foreach (var variableName in variableNames)
                {
                    table.list.Add(new VariableNode(variableName, type));
                }
            }
        }

        private void ParseFuncProcDecl(ITree tree, Table table)
        {
            //Осталось проверить процедура это или функция и в соттветсвии с этим добавить возвращаемый тип и кое чего еще дописать
            string name = tree.GetChild(0).Text;
            ITree args = tree.GetChild(1);
            Table localTable = this.ParseFuncProcArgs(args, table);
            
            this.InitParser(tree, localTable);
            //var fNode = new FuncNode(name,);    
        }

        private Table ParseFuncProcArgs(ITree tree, Table upperTable)
        {
            Table localTable = new Table();
            List<string> variableNames = new List<string>();
            for (int i = 0; i < tree.ChildCount; i++)
            {
                //Обход по всем потомкам VAR_DECL
                //Может быть несколько вариантов. Либо Var либо имя переменной
                if (tree.GetChild(i).Text == "var")
                {
                    this.ParseVarDecl(tree.GetChild(i), localTable);
                }
                else
                {
                    if (tree.GetChild(i).Text != "TYPE_DECL")
                    {
                        string type = tree.GetChild(i).GetChild(0).Text;
                        List<Node> nodes = new List<Node>();

                        foreach (var variableName in variableNames)
                        {
                            Node temp = new VariableNode(variableName, type);
                            if (upperTable.list.Contains(temp))
                            {
                                localTable.list.Add(temp);
                            }
                            else
                            {
                                throw new DataException(
                                    $"При разборе узла {tree.GetChild(i).Text} c предком {tree.Text} произошла ошибка:\n \"Переменная не объявлена в программе\"");
                            }
                        }
                    }
                    else
                    {
                        variableNames.Add(tree.GetChild(i).Text);
                    }
                }
            }
            return localTable;
        }
    }
}

