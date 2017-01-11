using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Parser.BodyNodes;
using CompilerConsole.Utils;

namespace CompilerConsole.ILGenerator
{
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
        ReadFile,
        While,
        DoWhile,
        WriteFile,
        Write,
        Convert,
        Concate,
        Parse
    }

    public enum ILToken
    {
        Method,

    }

    public enum ILReplacedToken
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
        private Dictionary<ILOperation, string> _operationDictionary;
        private Dictionary<Template, string> _templatesDictionary;
        private Dictionary<ILReplacedToken, string> _cilReplacedToken;

        private readonly StringBuilder _cilCode;

        public Generator() {
            this._cilCode = new StringBuilder();
            this.InitializeTemplates();
        }

        public void Generate(Parser.Parser parser) {
            this._cilCode.Append(this.Reader(Template.StartProgram));
            this._cilCode.AppendLine();
            var classDecl = this.Reader(Template.ClassDecl);
            classDecl = classDecl.Replace(this._cilReplacedToken[ILReplacedToken.ClassBody],
                this.ParseClass(parser.ProgramNode));
            this._cilCode.AppendLine(classDecl);
            this.Writer(this._cilCode.ToString());
        }

        private string ParseClass(BodyNode classBody) {
            var body = this.GenerateGlobalVar(classBody);

            foreach (var node in classBody) {
                if (node is FuncNode && (node as FuncNode).FuncType == FuncType.Cust) {
                    body += this.GenerateILMethod(node as FuncNode);
                }
            }
    
            return body;
        }

        #region Addition

        private void InitializeTemplates() {
            this._templatesDictionary = new Dictionary<Template, string>() {
                {Template.ClassDecl, "ClassDeclTemplate.txt"},
                {Template.DeclFuncFinich, "DeclFuncFinish.txt"},
                {Template.DeclMainFunc, "DeclMainFuncStart.txt"},
                {Template.StartFuncDecl, "StartFucDecl.txt"},
                {Template.StartProgram, "StartProgramTempate.txt"},
                {Template.LocalvariableDeclaration, "LocalvariableDeclaration.txt"},
                {Template.ConsoleWriteLine, "WriteLineTemplate.txt"},
                {Template.ConsoleReadLine, "ReadLineTemplate.txt"},
                {Template.CallMethod, "CallMethod.txt"},
                {Template.FieldDecl, "FieldDeclTemplate.txt"},
                {Template.CallField, "CallField.txt"},
                {Template.ArrDecl, "ArrDecl.txt"},
                {Template.Conj, "ConjTemplate.txt"},
                {Template.Dij, "DijTemplate.txt"},
                {Template.ReadFile, "ReadFileTemplate.txt"},
                {Template.While, "WhileTemplate.txt"},
                {Template.DoWhile, "DoWhileTemplate.txt"},
                {Template.Concate, "ConcateTemplate.txt" },
                {Template.Convert, "ConvertTemplate.txt" },
                {Template.Write, "WriteTemplate.txt" },
                {Template.WriteFile, "WriteFileTemplate.txt" },
                {Template.Parse, "Parse.txt" }
            };

            this._cilReplacedToken = new Dictionary<ILReplacedToken, string>() {
                {ILReplacedToken.MethodName, "{name}"},
                {ILReplacedToken.MethodArgs, "{args}"},
                {ILReplacedToken.Variables, "{variables}"},
                {ILReplacedToken.ClassBody, "{classBody}"},
            };
            this._operationDictionary = new Dictionary<ILOperation, string>() {
                {ILOperation.IntConstLoad, "ldc.i4"},
                {ILOperation.ReadLocalVariable, "ldloc"},
                {ILOperation.WriteLocalVariable, "stloc"},
                {ILOperation.WriteMethodArg, "starg"},
                {ILOperation.ReadMethodArg, "ldarg"},
                {ILOperation.WriteField, "stsfld"},
                {ILOperation.ReadField, "ldsfld"},
                {ILOperation.StringConstLoad, "ldstr"},
                {ILOperation.Add, "add"},
                {ILOperation.Sub, "sub"},
                {ILOperation.Div, "div"},
                {ILOperation.Mul, "mul"},
                {ILOperation.Call, "call"},
                {ILOperation.ReadArrStructElement, "ldelem.i4"},
                {ILOperation.WriteArrStructElement, "stelem.i4"},
                {ILOperation.ReadArrRefElement, "ldelem.ref"},
                {ILOperation.WriteArrRefElement, "stelem.ref"},
                {ILOperation.Ret, "ret"},
                {ILOperation.Conj, "{opline} brfalse {const line}"},
                {ILOperation.Dij, "{opline} brtrue {const line}"},
                {ILOperation.Neg, "ceq"},
                {ILOperation.Less, "clt"},
                {ILOperation.More, "cgt"}
            };
        }

        private string Reader(Template template) {
            var fileName = Environment.CurrentDirectory + "..\\..\\..\\Templates\\" + this._templatesDictionary[template];

            var file = new FileStream(fileName, FileMode.Open);
            var reader = new StreamReader(file);
            var result = reader.ReadToEnd();
            reader.Close();
            file.Close();
            return result;
        }

        private void Writer(string cilCode) {
            var file = new FileStream("cil.il", FileMode.Create);
            var reader = new StreamWriter(file);
            reader.Write(cilCode);
            reader.Close();
            file.Close();
        }

        #endregion
    }
}
