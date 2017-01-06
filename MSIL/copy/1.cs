using System;
namespace Program {
  public class Program{
  private static string s;
      public static void Main() {
        System.IO.File.WriteAllText("text","test", System.Text.Encoding.Unicode);
      }
  }
}