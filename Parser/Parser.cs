﻿using System;
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
        FuncProcDecl
    }

    /// <summary>
    /// Класс ответственный за парсинг AST дерева
    /// </summary>
    public partial class Parser {

        public ProgramNode ProgramNode { get; }

        private Dictionary<string, Token> _tokenDictionary;

        public Parser() {
            this.InitializeDictionary();
            this.ProgramNode = new ProgramNode(new Body());
        }

        private void InitializeDictionary() {
            this._tokenDictionary = new Dictionary<string, Token>() {
                {"BODY_EXPR", Token.Body},
                {"MAIN_BODY", Token.MainBody},
                {"FUNC_PROC_EXPR", Token.FuncProcDecl},
                {"VAR_DECL", Token.VarDecl}
            };
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
                    break;
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
            try {
                this.Action(treeNode, bodyNode, this._tokenDictionary[treeNode.Text]);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
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

        private DataType StringToArrDataType(string text)
        {
            switch (text)
            {
                case "integer":
                    {
                        return DataType.ArrInt;
                    }
                case "string":
                    {
                        return DataType.ArrString;
                    }
                case "char":
                    {
                        return DataType.ArrChar;
                    }
                case "boolean":
                    {
                        return DataType.ArrBool;
                    }
            }
            throw new TypeLoadException($"Типа {text} не существует!");
        }

        private Literal GetLiteralFromString(string text) {
            if (String.CompareOrdinal(text, "false") == 0 || String.CompareOrdinal(text, "true") == 0)
            {
                return new Literal(DataType.VarBool, bool.Parse(text));
            }

            Regex regEx = new Regex("^\".*\"$");
            if (regEx.IsMatch(text))
            {
                //Строка
                return new Literal(DataType.VarString, text);
            }

            regEx = new Regex("^\'[aA-zZ]\'$");
            if (regEx.IsMatch(text))
            {
                //Символ
                return new Literal(DataType.VarChar, char.Parse(text.Replace("\'", "")));
            }

            regEx = new Regex("^[0-9]+$");
            if (regEx.IsMatch(text))
            {
                //Целое
                return new Literal(DataType.VarInt, int.Parse(text));
            }

            return null;
        }

        public void Serialize()
        {
            using (FileStream fs = new FileStream("code.xml", FileMode.Create))
            {
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
    }
}
