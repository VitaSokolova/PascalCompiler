using System;
namespace Program {
  public class Program{
  private static string s;
      public static void Main() {
          s = System.IO.File.ReadAllText("test.txt");
          char r;
          bool flag = true;
          while(flag){
          Console.Write(s);
          }
          do{
            s=s+s;
          }while(flag);
         System.IO.File.WriteAllText("test.txt",s);
      }
  }
}