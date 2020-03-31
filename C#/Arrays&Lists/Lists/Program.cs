using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lists
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
             3. Task 3
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
        if (selection == '3')
        {
          Task3();
          Console.WriteLine();
        }
        if (selection == 'x')
        {
          break;
        }
      }
    }
    // Write a program that reads in 5 numbers. 
    // It then asks the user for another number and outputs whether the number has already been entered.
    static void Task1()
    {
      List<int> numList = new List<int>();
      for (int i = 0; i < 5; i++)
      {
        Console.Write("Enter in a integer: ");
        numList.Add(Convert.ToInt32(Console.ReadLine()));
      }
      Console.Write("Check if you entered an integer: ");
      int userNum = Convert.ToInt32(Console.ReadLine());
      // This bool check feels like a weird work around knowing if something was executed inside the foreach loop.
      // I feel as though this was a bit of a hack way of doing this.
      bool check = false;
      foreach (int num in numList)
      {
        if (num == userNum)
        {
          Console.WriteLine($"{num} is a part of the list.");
          check = true;
          // Incase list contains multiple of the same number checked.
          break;
        }
      }
      if (check == false)
      {
        Console.WriteLine($"{userNum} is not part of the list.");
      }
    }
    // As above except the program will tell the user how many times a repeated number has been entered
    static void Task2()
    {
      List<int> numList = new List<int>();
      for (int i = 0; i < 5; i++)
      {
        Console.Write("Enter in a integer: ");
        numList.Add(Convert.ToInt32(Console.ReadLine()));
      }
      Console.Write("Check if you entered an integer: ");
      int userNum = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      foreach (int num in numList)
      {
        if (num == userNum)
        {
          count += 1;
        }
      }
      if (count == 0)
      {
        Console.WriteLine($"{userNum} is not part of the list.");
      }
      else
      {
        Console.WriteLine($"{userNum} is a part of the list {count} times.");
      }
    }
    // A program stores words read from console, until the word "stop" is entered.  
    // It then outputs the words entered in reverse order.
    static void Task3()
    {
      List<string> userString = new List<string>();
      //   I just wanted to play with regex a bit even though its impractial for this scenario
      string stringRegex = @"([Ss][Tt][Oo][Pp])";
      Regex re = new Regex(stringRegex);
      for (; ; )
      {
        Console.WriteLine("The program will continue to ask for input until it is top to stop.");
        Console.Write("Enter in a string: ");
        string stringVar = Console.ReadLine();
        if (re.IsMatch(stringVar))
        {
          break;
        }
        userString.Add(stringVar);
      }
      foreach (string str in userString)
      {
        // Im not sure what would be the best way to go about this without printing the final comma at the end.
        Console.Write($"{str},");
      }
    }
  }
}
