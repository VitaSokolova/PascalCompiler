using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
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
            body_decl,
            FUNC_CALL,
            FUNC_CALL_ARGS
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
            this.dictionary.Add("FUNC_CALL",Token.FUNC_CALL);
            this.dictionary.Add("FUNC_CALL_ARGS", Token.FUNC_CALL_ARGS);
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
            switch (token) {
                case Token.body_decl: {
                    for (int i = 0; i < tree.ChildCount; i++) {
                        this.InitParser(tree.GetChild(i), table);
                    }
                    break;
                }

                #region VarDecl

                case Token.var_decl: {
                    var args = this.ParseVarDecl(tree, table);
                    int i = 0;
                    foreach (var node in args) {
                        node.IdNumber = i++;
                        node.Modificator = "global";
                        table.list.Add(node);
                    }
                    break;
                }

                    #endregion
                #region FUNC_PROC_DECL

                case Token.func_proc_decl: {
                    for (int i = 0; i < tree.ChildCount; i++) {
                        FuncNode funcNode = this.ParseFuncProcDecl(tree.GetChild(i), table);
                        if (tree.GetChild(i).ChildCount == 3) {
                            this.InitParser(tree.GetChild(i).GetChild(2), funcNode.BodyTable);
                        }
                        else {
                            this.InitParser(tree.GetChild(i).GetChild(1), funcNode.BodyTable);
                        }
                    }

                    break;
                }


                #endregion

                case Token.FUNC_CALL: {
                    FuncCall funcCallNode = this.ParseFuncCall(tree, table);
                    this.table.list.Add(funcCallNode);
                    break;
                }
            }
        }


        public void Serialize() {
            using (var fs = new FileStream("Code.xml", FileMode.Create)) {
                XmlSerializer sr = new XmlSerializer(typeof(Table));
                sr.Serialize(fs, this.table);
            }
        }
    }
}
