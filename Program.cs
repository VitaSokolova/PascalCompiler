using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CompilerConsole.CILGenerator;
using Lang2;
namespace CompilerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // В качестве входного потока символов устанавливаем консольный ввод
                ANTLRReaderStream input = new ANTLRReaderStream(Console.In);
                // Настраиваем лексер на этот поток
                Lang2Lexer lexer = new Lang2Lexer(input);
                // Создаем поток токенов на основе лексера
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                // Создаем парсер
                Lang2Parser parser = new Lang2Parser(tokens);
                // И запускаем первое правило грамматики!!!
                Object t;
                try {
                     t = parser.execute().Tree;
                }
                catch (Exception ex) {
                    
                    Console.WriteLine();
                    Console.WriteLine("Компилятор говорит: "+ex.Message);
                    Console.ReadKey();
                    return;
                }
                
                ITree tree = t as ITree;
                DrawingTreeLib.Views.DrawingTreeLib.Initialize(tree);
               var p =  new Parser.Parser();
                    p.Parse(tree);
                p.MakeGlobalVariables();
                p.MakeMethodArgs();
                p.MakeLocalVarNumbers();
                p.Serialize();
                CILGenerator.Generator tp = new Generator();
                tp.Generate(p);
                Console.ReadKey();
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
