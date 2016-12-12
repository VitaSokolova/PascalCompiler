using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Antlr.Runtime.Tree;

namespace CompilerConsole.Parser
{
    partial class Parser
    {
        enum Token
        {
            var_decl,
            type_decl,
            func_proc_decl,
            body_decl
        }

        Table table;
        Dictionary<String, Token> dictionary;

        public Parser()
        {
            this.table = new Table(null);
            InitDict();
        }

        private void InitDict()
        {
            this.dictionary = new Dictionary<string, Token>();
            this.dictionary.Add("VAR_DECL", Token.var_decl);
            this.dictionary.Add("TYPE_DECL", Token.type_decl);
            this.dictionary.Add("FUNC_PROC_EXPR", Token.func_proc_decl);
            this.dictionary.Add("BODY_EXPR", Token.body_decl);
        }

        public void Parse(ITree tree)
        {
            this.InitParser(tree.GetChild(0).GetChild(1), this.table);
        }

        private void InitParser(ITree tree, Table table)
        {
            Token token;
            if (!this.dictionary.TryGetValue(tree.Text, out token))
            {
            }
            else
            {
                this.Action(tree, table, token);
            }
        }

        private void Action(ITree tree, Table table, Token token)
        {
            switch (token)
            {
                case Token.body_decl:
                {
                    for (int i = 0; i < tree.ChildCount; i++)
                    {
                        this.InitParser(tree.GetChild(i), table);
                    }
                    break;
                }

                case Token.var_decl:
                {
                    var args = this.ParseVarDecl(tree, table);
                    int i = 0;
                    foreach (var node in args)
                    {
                        node.IdNumber = i++;
                        node.Modificator = "global";
                        table.list.Add(node);
                    }                   
                    break;
                }
                case Token.func_proc_decl:
                {
                    for (int i = 0; i < tree.ChildCount; i++)
                    {
                        this.ParseFuncProcDecl(tree.GetChild(i), table);
                    }

                    break;
                }
            }
        }
    }
}
