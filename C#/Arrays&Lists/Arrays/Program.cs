using System;

namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      for (; ; )
      {
        Console.WriteLine(@"Would You Like to...
             1. Task 1
             2. Task 2
             ");
        char selection = Convert.ToChar(Console.ReadLine());
        if (selection == '1')
        {
          Task1();
          Console.WriteLine();
        }
        if (selection == '2')
        {
          Task2();
          Console.WriteLine();
        }
        if (selection == 'x')
        {
          break;
        }
      }
    }
    // Create a program that reads in 5 names from the console.  
    // It then prints out "Hello <name>" for all the names entered
    static void Task1()
    {
      string[] names = new string[5];
      for (int i = 0; i < 5; i++)
      {
        Console.Write("Enter in a name: ");
        names[i] = Console.ReadLine();
        Console.WriteLine();
      }
      foreach (string name in names)
      {
        Console.WriteLine($"Hello, {name}!");
      }
    }
    // A program starts with the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0. 
    // Write a program that adds all numbers together and outputs the total.
    static void Task2()
    {
      int[] numArray = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
      int count = 0;
      foreach (int num in numArray)
      {
        count += num;
      }
      Console.WriteLine(count);
    }
  }
}
