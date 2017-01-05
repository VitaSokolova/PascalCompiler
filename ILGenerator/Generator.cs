﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CompilerConsole.Parser.BodyNodes;
using CompilerConsole.Utils;

namespace CompilerConsole.CILGenerator
{

    /*
     bge: <
     ble: >
     bne.un: ==
     beq: !=
     bgt: <=
     blt: >=
         */

    #region Enums
    enum Template {
        ClassDecl,
        DeclFuncFinich,
        DeclMainFunc,
        StartFuncDecl,
        StartProgram,
        LocalvariableDeclaration,
        /// <summary>
        /// Содержит триггер {type} - тип данных, который нужно вывести
        /// </summary>
        ConsoleWriteLine,
        ConsoleReadLine,
        /// <summary>
        /// Вызов собственного метода имеет триггеры {type} - тип который возвращает метод
        /// {name}  - имя метода 
        /// {args} - типы, принимаемые методом
        /// </summary>
        CallMethod,
        /// <summary>
        /// Декларация глобальной переменной. Иммет триггеры:
        /// {type} - тип переменной
        /// {name} - имя переменной
        /// </summary>
        FieldDecl,
        /// <summary>
        /// Обращение к глобальной переменной. Имеет триггеры:
        /// {type} - тип переменной
        /// {name} - имя переменной
        /// </summary>
        CallField,
        /// <summary>
        /// Создание массива:
        /// {type} - тип массива
        /// </summary>
        ArrDecl,
        Conj,
        Dij,
        ReadFile
    }

    public enum CILToken
    {
        Method,

    }

    public enum CILReplacedToken
    {
        MethodName,
        MethodArgs,
        Variables,
        ClassBody
    }

    public enum ILOperation
    {
        /// <summary>
        /// CIL синтаксис: ldc.i4 someLiterals(hex)
        /// </summary>
        IntConstLoad,

        /// <summary>
        /// CIL синтаксис:  ldloc.{variableNumber}
        /// </summary>
        ReadLocalVariable,

        /// <summary>
        /// CIL синтаксис:  stloc.{variableNumber}
        /// </summary>
        WriteLocalVariable,

        /// <summary>
        /// CIL синтаксис:  ldarg {variableNumber}
        /// </summary>
        ReadMethodArg,
        /// <summary>
        /// IL синтаксис: stfld {type} {variable reference}
        /// <example>stfld int32 Program.Program::q</example>
        /// </summary>
        WriteField,
        /// <summary>
        /// IL синтаксис: ldfld {type} {variable reference}
        /// <example>ldfld int32 Program.Program::q</example>
        /// </summary>
        ReadField,
        /// <summary>
        /// CIL синтаксис:  ldloc.{variableNumber}
        /// </summary>
        WriteMethodArg,
        StringConstLoad,
        WriteArrStructElement,
        ReadArrStructElement,
        ReadArrRefElement,
        WriteArrRefElement,
        Add,
        Sub,
        Div,
        Mul,
        Call,
        Ret,
        Dij,
        Conj,
        Neg,
        Less,
        More
    }
#endregion

    public partial class Generator {
        private  Dictionary<ILOperation, string> _operationDictionary;
        private Dictionary<Template, string> templatesDictionary;
        private Dictionary<CILReplacedToken, string> cilReplacedToken;

        private StringBuilder cilCode { get; set; }

        public Generator() {
            this.cilCode = new StringBuilder();
            this.InitializeTemplates();
        }

        public void Generate(Parser.Parser parser)
        {
            this.cilCode.Append(this.Reader(Template.StartProgram));
            this.cilCode.AppendLine();
            string classDecl = this.Reader(Template.ClassDecl);
            classDecl = classDecl.Replace(this.cilReplacedToken[CILReplacedToken.ClassBody], this.ParseClass(parser.ProgramNode.BodyTable));
            this.cilCode.AppendLine(classDecl);
            this.Writer(this.cilCode.ToString());
        }

        private string ParseClass(Body classBody) {
            string body = this.GenerateGlobalVar(classBody);

            foreach (var node in classBody.Nodes) {
                if (node is FuncNode && (node as FuncNode).FuncType == FuncType.Cust) {
                    body += this.GenerateCILMethod(node as FuncNode);
                }
            }

            return body;
        }

        #region Addition
        private void InitializeTemplates() {
            this.templatesDictionary = new Dictionary<Template, string>() {
                { Template.ClassDecl , "ClassDeclTemplate.txt" },
                { Template.DeclFuncFinich, "DeclFuncFinish.txt" },
                { Template.DeclMainFunc, "DeclMainFuncStart.txt" },
                { Template.StartFuncDecl, "StartFucDecl.txt" },
                { Template.StartProgram, "StartProgramTempate.txt" },
                { Template.LocalvariableDeclaration, "LocalvariableDeclaration.txt" },
                { Template.ConsoleWriteLine, "WriteLineTemplate.txt" },
                { Template.ConsoleReadLine, "ReadLineTemplate.txt" },
                { Template.CallMethod, "CallMethod.txt" },
                { Template.FieldDecl, "FieldDeclTemplate.txt" },
                { Template.CallField, "CallField.txt" },
                { Template.ArrDecl, "ArrDecl.txt" },
                { Template.Conj, "ConjTemplate.txt" },
                { Template.Dij, "DijTemplate.txt" },
                { Template.ReadFile, "ReadFileTemplate.txt"}
            };

            this.cilReplacedToken = new Dictionary<CILReplacedToken, string>() {
                { CILReplacedToken.MethodName, "{name}" },
                { CILReplacedToken.MethodArgs, "{args}" },
                { CILReplacedToken.Variables, "{variables}" },
                { CILReplacedToken.ClassBody, "{classBody}" },
            };

            this._operationDictionary = new Dictionary<ILOperation, string>() {
                { ILOperation.IntConstLoad, "ldc.i4" },
                { ILOperation.ReadLocalVariable, "ldloc" },
                { ILOperation.WriteLocalVariable, "stloc" },
                { ILOperation.WriteMethodArg, "starg" },
                { ILOperation.ReadMethodArg, "ldarg" },
                { ILOperation.WriteField, "stsfld" },
                { ILOperation.ReadField, "ldsfld" },
                { ILOperation.StringConstLoad, "ldstr" },
                { ILOperation.Add, "add" },
                { ILOperation.Sub, "sub" },
                { ILOperation.Div, "div" },
                { ILOperation.Mul, "mul" },
                { ILOperation.Call, "call" },
                { ILOperation.ReadArrStructElement, "ldelem.i4" },
                { ILOperation.WriteArrStructElement, "stelem.i4" },
                { ILOperation.ReadArrRefElement, "ldelem.ref" },
                { ILOperation.WriteArrRefElement, "stelem.ref" },
                { ILOperation.Ret, "ret" },
                { ILOperation.Conj, "{opline} brfalse {const line}" },
                { ILOperation.Dij, "{opline} brtrue {const line}" },
                { ILOperation.Neg, "ceq"},
                { ILOperation.Less, "clt"},
                { ILOperation.More, "cgt"}
            };
        }

        private string Reader(Template template) {
            string fileName =Environment.CurrentDirectory + "..\\..\\..\\Templates\\"+ this.templatesDictionary[template];

            FileStream file = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string result = reader.ReadToEnd();
            reader.Close();
            file.Close();
            return result;
        }

        private void Writer(string cilCode) {
            FileStream file = new FileStream("cil.il", FileMode.Create);
            StreamWriter reader = new StreamWriter(file);
            reader.Write(cilCode);
            reader.Close();
            file.Close();
        }

        #endregion
    }
}
