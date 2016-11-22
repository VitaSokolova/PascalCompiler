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
            func_proc_decl
        }

        Table table;
        Dictionary<String, Token> dictionary;

        public Parser()
        {
            this.table = new Table();
            InitDict();
        }

        private void InitDict()
        {
            this.dictionary = new Dictionary<string, Token>();
            this.dictionary.Add("VAR_DECL", Token.var_decl);
            this.dictionary.Add("TYPE_DECL", Token.type_decl);
            this.dictionary.Add("PROC_DECL", Token.func_proc_decl);
            this.dictionary.Add("FUNC_DECL", Token.func_proc_decl);
        }

        public void Parse(ITree tree)
        {
            this.InitParser(tree.GetChild(0), this.table);
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
            for (int i = 0; i < tree.ChildCount; i++)
            {
                this.InitParser(tree.GetChild(i), table);
            }
        }

        private void Action(ITree tree, Table table, Token token)
        {
            switch (token)
            {
                case Token.var_decl:
                {
                    this.ParseVarDecl(tree, table);
                    break;
                }
                case Token.func_proc_decl:
                {
                    this.ParseFuncProcDecl(tree, table);
                    break;
                }
            }
        }
    }
}
