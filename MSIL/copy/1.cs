using System;
namespace Program {
  public class Program{
  private static string s;
      public static void Main() {
          s = System.IO.File.ReadAllText("test.txt");
          Console.WriteLine(s);
      }

      public static void Test(int[] a){
          a[0] = 100;
          Console.WriteLine(a[0]);
      }
  }
}