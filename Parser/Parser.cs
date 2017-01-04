using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Parser.BodyNodes;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser {
    public enum Token {
        Body,
        MainBody,
        VarDecl,
        FuncProcDecl,
        FuncCall
    }

    /// <summary>
    /// Класс ответственный за парсинг AST дерева
    /// </summary>
    public partial class Parser {

        public ProgramNode ProgramNode { get; }

        private Dictionary<string, Token> _tokenDictionary;
        private Dictionary<string, ExprToken> _exprTokensDictionary;

        public Parser() {
            this.InitializeDictionary();
            this.ProgramNode = new ProgramNode(new Body());
        }

        private void InitializeDictionary() {
            this._tokenDictionary = new Dictionary<string, Token>() {
                {"BODY_EXPR", Token.Body},
                {"MAIN_BODY", Token.MainBody},
                {"FUNC_PROC_EXPR", Token.FuncProcDecl},
                {"VAR_DECL", Token.VarDecl},
                { "FUNC_CALL", Token.FuncCall}
            };

            #region exprTokensDictionary initialize

            this._exprTokensDictionary = new Dictionary<string, ExprToken>();
            this._exprTokensDictionary.Add("+", ExprToken.Add);
            this._exprTokensDictionary.Add("-", ExprToken.Sub);
            this._exprTokensDictionary.Add("*", ExprToken.Mult);
            this._exprTokensDictionary.Add("/", ExprToken.Div);
            this._exprTokensDictionary.Add(":=", ExprToken.Ass);
            this._exprTokensDictionary.Add("=", ExprToken.IsEqual);
            this._exprTokensDictionary.Add("<", ExprToken.IsLess);
            this._exprTokensDictionary.Add(">", ExprToken.IsMore);
            this._exprTokensDictionary.Add("<=", ExprToken.IsLessOrEqual);
            this._exprTokensDictionary.Add(">=", ExprToken.IsMoreOrEqual);
            this._exprTokensDictionary.Add("AND", ExprToken.Conj);
            this._exprTokensDictionary.Add("OR", ExprToken.Dij);
            this._exprTokensDictionary.Add("NOT", ExprToken.Neg);

            #endregion

        }

        public void Parse(ITree root) {
            //Берем потомов, потому что у нас дерево не очень хорошо генерируется и мы хотим взять сразу тело
            this.Parse(root.GetChild(0).GetChild(1), this.ProgramNode);
        }


        private void Action(ITree treeNode, BodyNode bodyNode, Token token) {
            switch (token) {
                case Token.Body: {
                    for (int i = 0; i < treeNode.ChildCount; i++) {
                        this.Parse(treeNode.GetChild(i), bodyNode);
                    }
                    break;
                }
                case Token.VarDecl: {
                    var variables = this.ParseVarDecl(treeNode, bodyNode);
                    foreach (var variableNode in variables) {
                        bodyNode.AddNode(variableNode);
                    }
                    break;
                }
                case Token.FuncProcDecl: {
                    for (int i = 0; i < treeNode.ChildCount; i++) {
                        var meth = this.ParseFuncDeclare(treeNode.GetChild(i), bodyNode);
                        bodyNode.AddNode(meth);
                    }
                    return;
                }
                    case Token.FuncCall: {
                        bodyNode.AddNode(this.ParseFuncCall(treeNode,bodyNode));
                    return;
                }
                case Token.MainBody: {
                    var mainMethod = new FuncNode(DataType.Void, "Main", new List<VariableNode>(), new Body());
                    mainMethod.ParentBodyNode = this.ProgramNode;
                    this.ProgramNode.AddNode(mainMethod);
                    this.Action(treeNode, mainMethod, Token.Body);
                    break;
                }
            }
        }

        private void Parse(ITree treeNode, BodyNode bodyNode) {
            if (this.IsExpr(treeNode.Text)) {
                bodyNode.AddNode(this.ParseExpression(treeNode, bodyNode));
            }
            else {

                try {
                    this.Action(treeNode, bodyNode, this._tokenDictionary[treeNode.Text]);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private DataType StringToVarDataType(string text) {
            switch (text) {
                case "integer": {
                    return DataType.VarInt;
                }
                case "string": {
                    return DataType.VarString;
                }
                case "char": {
                    return DataType.VarChar;
                }
                case "boolean": {
                    return DataType.VarBool;
                }
            }
            throw new TypeLoadException($"Типа {text} не существует!");
        }

        private DataType StringToArrDataType(string text) {
            switch (text) {
                case "integer": {
                    return DataType.ArrInt;
                }
                case "string": {
                    return DataType.ArrString;
                }
                case "char": {
                    return DataType.ArrChar;
                }
                case "boolean": {
                    return DataType.ArrBool;
                }
            }
            throw new TypeLoadException($"Типа {text} не существует!");
        }

        private bool IsExpr(string text)
        {
            ExprToken token;

            if (this._exprTokensDictionary.TryGetValue(text, out token))
            {
                return true;
            }
            return false;
        }

        private ExprToken GetExpr(string expr)
        {
            ExprToken token;

            if (this._exprTokensDictionary.TryGetValue(expr, out token))
            {
                return token;
            }
            return ExprToken.Error;
        }

        private Literal GetLiteralFromString(string text) {
            if (String.CompareOrdinal(text, "false") == 0 || String.CompareOrdinal(text, "true") == 0) {
                return new Literal(DataType.VarBool, bool.Parse(text));
            }

            Regex regEx = new Regex("^\".*\"$");
            if (regEx.IsMatch(text)) {
                //Строка
                return new Literal(DataType.VarString, text);
            }

            regEx = new Regex("^\'[aA-zZ]\'$");
            if (regEx.IsMatch(text)) {
                //Символ
                return new Literal(DataType.VarChar, char.Parse(text.Replace("\'", "")));
            }

            regEx = new Regex("^[0-9]+$");
            if (regEx.IsMatch(text)) {
                //Целое
                return new Literal(DataType.VarInt, int.Parse(text));
            }

            return null;
        }

        #region After parsing methods

        public void Serialize() {
            using (FileStream fs = new FileStream("code.xml", FileMode.Create)) {
                XmlSerializer serializer = new XmlSerializer(typeof(ProgramNode));
                serializer.Serialize(fs, this.ProgramNode);
            }
        }

        public void MakeGlobalVariables() {
            foreach (var varNode in this.ProgramNode) {
                if (varNode is VariableNode) {
                    (varNode as VariableNode).IsGlobal = true;
                }
            }
        }

        public void MakeMethodArgs() {
            foreach (var node in this.ProgramNode) {
                if (node is FuncNode) {
                    var funcNode = (FuncNode) node;
                    for (int i = 0; i < funcNode.Args.Count; i++) {
                        var arg = funcNode.Args[i];
                        arg.IsMethodArg = true;
                        arg.Number = i;
                    }
                }
            }
        }

        public void MakeLocalVarNumbers() {
            foreach (var node in this.ProgramNode) {
                if (node is BodyNode) {
                    var funcNode = (FuncNode) node;
                    for (int i = 0; i < funcNode.BodyTable.Nodes.Count; i++) {
                        var arg = funcNode[i];
                        if (arg is VariableNode) {
                            (arg as VariableNode).Number = i;
                        }
                    }
                }
            }
        }

        #endregion

    }
}
