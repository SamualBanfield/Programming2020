// Not sure if or how you wanted us to do desk checks on our psuedo code.

using System;

namespace Exercise_1
{
  class Program
  {
    static void Main(string[] args)
    {
      for (; ; )
      {
        Console.Write("Start Task 1 or 2: ");
        char selection = Convert.ToChar(Console.ReadLine());
        if (selection == '1')
        {
          Task1();
        }
        if (selection == '2')
        {
          Task2();
        }
        if (selection == 'x')
        {
          break;
        }
      }
    }
    // A program receives a user's name and prints it 10 times on the same line. This process happens 10 times.
    static void Task1()
    {
      Console.WriteLine("Enter Your Name: ");
      string name = Console.ReadLine();
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine();
        for (int j = 0; j < 10; j++)
        {
          Console.Write(name);
        }
      }
      Console.WriteLine();
    }
    // A program receives a user's name and prints it for the amount of times that the user specifies.
    static void Task2()
    {
      Console.WriteLine("Enter Your Name: ");
      string name = Console.ReadLine();
      Console.WriteLine("Enter The Desired Rows: ");
      int rows = Convert.ToInt16(Console.ReadLine());
      Console.WriteLine("Enter The Desired Columns: ");
      int columns = Convert.ToInt16(Console.ReadLine());
      for (int i = 0; i < rows; i++)
      {
        Console.WriteLine();
        for (int j = 0; j < columns; j++)
        {
          Console.Write(name);
        }
      }
      Console.WriteLine();
    }
  }
}
