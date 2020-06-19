using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Assignment_1_Bingo
{
  class Program
  {
    static void Main(string[] args)
    {
      string selection;
      string secondarySelection;
      Console.Write("Please enter in an upper limit on generated numbers: ");
      int upperLimit = Convert.ToInt32(Console.ReadLine());
      List<int> drawnNumbers = new List<int>();
      Random rand = new Random();

      // Im not sure if using for(;;) is good code.
      // it localises all the variables inside it but I didnt want to fill my code with boolens and while loops

      for (; ; )
      {
        for (; ; )
        {
          Console.Write(@"
Please make a selection...
1.Generate a new number
2.Show all drawn numbers
3.Check if a number has been drawn
4.Check if any numbers in a set are already drawn
5.Check stats
6.Exit
");
          selection = Console.ReadLine();
          if (HandleCheck(selection))
          {
            break;
          }
        }
        switch (selection)
        {
          case "1":
            drawnNumbers = GenerateNum(upperLimit, drawnNumbers, rand);
            FormatList(drawnNumbers);
            break;
          case "2":
            for (; ; )
            {
              Console.Write(@"
Please make a selection...
1.Show all numbers in the oder they were drawn in
2.Show all numbers in numerical order
");
              secondarySelection = Console.ReadLine();
              if (HandleCheck(secondarySelection))
              {
                break;
              }
            }
            if (secondarySelection == "1")
            {
              FormatList(drawnNumbers);
            }
            if (secondarySelection == "2")
            {
              List<int> sortedNumbers = new List<int>();
              foreach (int num in drawnNumbers)
              {
                sortedNumbers.Add(num);
              }
              sortedNumbers.Sort();
              FormatList(sortedNumbers);
            }
            break;
          case "3":
            for (; ; )
            {
              Console.Write("Enter in a number or press any other option to exit:");
              try
              {
                int checkNum = Convert.ToInt32(Console.ReadLine());
                if (drawnNumbers.Contains(checkNum))
                {
                  Console.WriteLine("{0} has already been drawn", checkNum);
                }
                else
                {
                  Console.WriteLine("{0} has not been drawn", checkNum);
                }
              }
              catch
              {
                break;
              }
            }
            break;
          // I wasnt quite sure how the existing set of numbers would be formated so I just winged it with a format.
          // And I only output what numbers were already drawn as to lower the cluster of text that someone would have to filter though.
          case "4":
            for (; ; )
            {
              Console.Write(@"Enter in a set of numbers to the format of '1,2,3..etc', any invalid formatting will return to menu.
");
              try
              {
                string[] numberArray = Console.ReadLine().Split(',');
                foreach (string num in numberArray)
                {
                  if (drawnNumbers.Contains(Convert.ToInt32(num)))
                  {
                    Console.WriteLine("{0} has already been drawn", num);
                  }
                }
                break;
              }
              catch
              {
                break;
              }
            }
            break;
          case "5":
            for (; ; )
            {
              Console.Write(@"
Please make a selection...
1.Total of current numbers
2.Average current numbers
");
              secondarySelection = Console.ReadLine();
              if (HandleCheck(secondarySelection))
              {
                break;
              }
            }
            if (secondarySelection == "1")
            {
              Console.WriteLine("Total of drawn numbers: {0}", drawnNumbers.Sum());
            }
            if (secondarySelection == "2")
            {
              Console.WriteLine("Total of drawn numbers: {0}", drawnNumbers.Average());
            }
            break;
          case "6":
            SaveFile(drawnNumbers);
            Environment.Exit(0);
            break;
          default:
            Environment.Exit(0);
            break;
        }
      }
    }

    static List<int> GenerateNum(int upperLimit, List<int> drawnNumbers, Random rand)
    {
      int LoopThreshold = 1000;
      int loopCount = 0;
      for (; ; )
      {
        int newNum = rand.Next(1, upperLimit + 1);
        if (!drawnNumbers.Contains(newNum))
        {
          drawnNumbers.Add(newNum);
          return drawnNumbers;
        }
        loopCount += 1;
        if (loopCount == LoopThreshold)
        {
          Console.WriteLine("It would seem that you have generated every number.");
          return drawnNumbers;
        }
      }
    }
    static void FormatList(List<int> drawnNumbers)
    {
      var formatedArray = drawnNumbers.ConvertAll(x => x.ToString()).ToArray();
      Console.WriteLine("{0}", string.Join(", ", formatedArray));
    }
    static bool HandleCheck(string var)
    {
      try
      {
        Convert.ToInt32(var);
        return true;
      }
      catch
      {
        Console.WriteLine("Please ensure that you are entering a non-negetive integer");
        return false;
      }
    }
    static void SaveFile(List<int> drawnNumbers)
    {
      var formatedArray = drawnNumbers.ConvertAll(x => x.ToString()).ToArray();
      File.WriteAllLines("drawn_numbers.txt", formatedArray);
    }
  }
}