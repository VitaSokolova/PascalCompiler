using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CompilerConsole.CILGenerator;
using Lang2;

namespace CompilerConsole {
    class Program {
        static void Main(string[] args) {
            try {
                ANTLRReaderStream input;
                FileStream fileStream = null;
                TextReader reader = null;
                if (args.Length != 0) {
                    fileStream = new FileStream(args[0], FileMode.Open);
                    reader = new StreamReader(fileStream);
                    input = new ANTLRReaderStream(reader);
                }
                else {
                    input = new ANTLRReaderStream(Console.In);
                }

                Lang2Lexer lexer = new Lang2Lexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                Lang2Parser parser = new Lang2Parser(tokens);
                object t;

                try {
                    t = parser.execute().Tree;
                }
                catch (Exception ex) {

                    Console.WriteLine();
                    Console.WriteLine("Компилятор говорит: " + ex.Message);
                    Console.ReadKey();
                    return;
                }

                ITree tree = t as ITree;
                DrawingTreeLib.Views.DrawingTreeLib.Initialize(tree);
                var p = new Parser.Parser();
                p.Parse(tree);
                p.MakeGlobalVariables();
                p.MakeMethodArgs();
                p.MakeLocalVarNumbers();
                try {
                   // p.Serialize();
                }
                catch (Exception) {
                    
                    Console.WriteLine("Ошибка при генерации XML документа");
                }
                
                CILGenerator.Generator tp = new Generator();
                tp.Generate(p);
                Console.WriteLine("Генерация IL кода успешно завершена");

                fileStream?.Close();
                reader?.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
            
        }
    }
}
