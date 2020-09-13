using System;

namespace Exercise_2
{
  class Program
  {
    static void Main(string[] args)
    {
      for (; ; )
      {
        Console.WriteLine(@"Would You Like to...
             1. Print Downward
             2. Print Upward
             ");
        char selection = Convert.ToChar(Console.ReadLine());
        if (selection == '1')
        {
          Downward();
        }
        if (selection == '2')
        {
          Upward();
        }
        if (selection == 'x')
        {
          break;
        }
      }
    }
    static void Downward()
    {
      int xcounter = 11;
      int spacecounter = 0;
      for (int i = 0; i < 6; i++)
      {
        for (int k = 0; k < spacecounter; k++)
        {
          Console.Write(" ");
        }
        for (int l = 0; l < xcounter; l++)
        {
          Console.Write("x");
        }
        Console.WriteLine();
        xcounter -= 2;
        spacecounter += 1;
      }
    }
    static void Upward()
    {
      int xcounter = 1;
      int spacecounter = 5;
      for (int i = 0; i < 6; i++)
      {
        for (int k = 0; k < spacecounter; k++)
        {
          Console.Write(" ");
        }
        for (int l = 0; l < xcounter; l++)
        {
          Console.Write("x");
        }
        Console.WriteLine();
        xcounter += 2;
        spacecounter -= 1;
      }
    }
  }
}
