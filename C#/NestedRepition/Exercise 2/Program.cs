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
      Console.Write("Enter the Length of the Longest Row: ");
      int num = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < num; i++)
      {
        int j = 0;
        while (j <= i)
        {
          Console.Write("x");
          j += 1;
        }
        Console.WriteLine();
      }
    }
    static void Upward()
    {
      Console.Write("Enter the Length of the Longest Row: ");
      int num = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < num; i++)
      {
        for (int j = 0; num - i > j; j++)
        {
          Console.Write("x");
        }
        Console.WriteLine();
      }
    }
  }
}
