using System;

namespace Reversed_Strings
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "dlrow";
      // string reversed;
      for (int i = str.Length - 1; i <= 0; i--)
      {
        Console.Write(str[i]);
      }
      Console.ReadKey();
    }
  }
}
