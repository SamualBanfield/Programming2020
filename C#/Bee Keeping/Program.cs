//S.Banfield
//09/08/2020
//BeeKeeping System

using System;
using System.Collections.Generic;

namespace Bee_Keeping
{
  class Program
  {
    static void Main(string[] args)
    {
      //Initializing Bees, Hives and Queens

      //Hive one 
      var Elizabeth = new Queen("Elizabeth");
      var John = new Bee("John", 3.2f);
      var Paul = new Bee("Paul", 2.7f);
      var George = new Bee("George", 1.1f);
      var Ringo = new Bee("Ringo", 2f);
      List<Bee> HiveOneList = new List<Bee>(){
        Elizabeth, John, Paul, George, Ringo
      };
      List<Queen> QueensInHiveOne = new List<Queen>(){
        Elizabeth
       };
      //Hive Two
      var Mary = new Queen("Mary");
      var Kurt = new Bee("Kurt", 2.3f);
      var Dave = new Bee("Dave", 7.4f);
      var Krist = new Bee("Krist", 1.5f);
      List<Bee> HiveTwoList = new List<Bee>(){
        Mary, Kurt, Dave, Krist
      };
      List<Queen> QueensInHiveTwo = new List<Queen>(){
        Mary
      };
      //Initializing Hives
      var HiveOne = new Hive(10, HiveOneList, QueensInHiveOne);
      var HiveTwo = new Hive(10, HiveTwoList, QueensInHiveTwo);
      //Used to keep track of how many hives we have
      List<Hive> HiveList = new List<Hive>(){
        HiveOne, HiveTwo
      };

      //Interface
      bool mainLoop = true;
      while (mainLoop == true)
      {
        int selection = Selection();
        switch (selection)
        {
          case 1:
            HiveReport(HiveList);
            break;
          case 2:
            SpawnBee(HiveList);
            break;
          case 3:
            CollectHoney(HiveList);
            break;
          case 4:
            HiveList = AddHive(HiveList);
            break;
          case 5:
            AddBee(HiveList);
            break;
          case 6:
            AddQueen(HiveList);
            break;
          case 7:
            mainLoop = false;
            break;
          default:
            Console.WriteLine(@"
Please ensure that you are entering a valid choice.
");
            break;
        }
      }
      //Write
      System.Environment.Exit(1);
    }
    static int Selection()
    {
      for (; ; )
      {
        Console.WriteLine(@"
Please Make a selection...
1. Reports on curent Hives
2. Spawn a new Bee
3. Collect Honey
4. Add a Hive
5. Add a Bee
6. Add a Queen
7. Save & Exit
");
        string input = Console.ReadLine();
        if (ValidateInt(input) == true)
        {
          return Convert.ToInt32(input);
        }
        else
        {
          Console.WriteLine(@"
Please ensure that you are entering a valid choice.
");
        }
      }
    }

    static void HiveReport(List<Hive> HiveList)
    {
      for (; ; )
      {
        int counter = 1;
        Console.WriteLine(@"
Please Select Which Hive You Wish To View...");
        foreach (Hive hive in HiveList)
        {
          Console.WriteLine(counter + ". Hive.");
          counter += 1;
        }
        Console.WriteLine(counter + ". Exit.");
        string input = Console.ReadLine();
        if (ValidateInt(input) == true)
        {
          if (Convert.ToInt32(input) <= HiveList.Count)
          {
            HiveList[Convert.ToInt32(input) - 1].Report();
            return;
          }
          else if (Convert.ToInt32(input) == HiveList.Count + 1)
          {
            return;
          }
        }
        else
        {
          Console.WriteLine(@"
Please ensure that you are entering a valid choice.
");
        }
      }
    }
    static void SpawnBee(List<Hive> HiveList)
    {
      for (; ; )
      {
        int counter = 1;
        Console.WriteLine(@"
      Please Select Which Hive You Wish To View...");
        foreach (Hive hive in HiveList)
        {
          Console.WriteLine(counter + ". Hive.");
          counter += 1;
        }
        Console.WriteLine(counter + ". Exit.");
        string hiveSelection = Console.ReadLine();
        //This is where i realised it would have been easier if I had just put more fuctions in my classes
        try
        {
          Hive overLoadCheck = HiveList[Convert.ToInt32(hiveSelection) - 1];
        }
        catch (System.Exception)
        {
          return;
        }
        if (ValidateInt(hiveSelection) == true && HiveList[Convert.ToInt32(hiveSelection) - 1].BeeList.Count < HiveList[Convert.ToInt32(hiveSelection) - 1].maxBees)
        {
          if (Convert.ToInt32(hiveSelection) <= HiveList.Count)
          {
            int i = 1;
            Console.WriteLine(@"
      Select a Queen...
      ");
            foreach (Queen queen in HiveList[Convert.ToInt32(hiveSelection) - 1].QueenList)
            {
              Console.WriteLine(i + ". " + queen.name);
              i += 1;
            }
            Console.WriteLine(i + ". Exit.");
            string queenSelect = Console.ReadLine();
            if ((ValidateInt(queenSelect) == true) && (Convert.ToInt32(queenSelect) <= HiveList[Convert.ToInt32(hiveSelection) - 1].QueenList.Count))
            {
              HiveList[Convert.ToInt32(hiveSelection) - 1].QueenList[Convert.ToInt32(queenSelect) - 1].MakeBee(HiveList[Convert.ToInt32(hiveSelection) - 1]);
              return;
            }
            else if (Convert.ToInt32(queenSelect) == HiveList[Convert.ToInt32(hiveSelection) - 1].QueenList.Count + 1)
            {
              return;
            }
            else
            {
              Console.WriteLine(@"
      Please ensure that you are entering a valid choice.
      ");
            }
          }
          else if (Convert.ToInt32(hiveSelection) == HiveList.Count + 1)
          {
            return;
          }
          else
          {
            Console.WriteLine(@"
      Please ensure that you are entering a valid choice.
      ");
          }
        }
        else if (HiveList[Convert.ToInt32(hiveSelection) - 1].BeeList.Count >= HiveList[Convert.ToInt32(hiveSelection) - 1].maxBees)
        {
          Console.WriteLine(@"
      The hive you are trying to add to is currently full.
      ");
        }
      }
    }
    static void CollectHoney(List<Hive> HiveList)
    {
      for (; ; )
      {
        int counter = 1;
        Console.WriteLine(@"
Please Select Which Hive You Wish To View...");
        foreach (Hive hive in HiveList)
        {
          Console.WriteLine(counter + ". Hive.");
          counter += 1;
        }
        Console.WriteLine(counter + ". Exit.");
        string input1 = Console.ReadLine();
        Console.Write(@"
Days since last collevtion:");
        string input2 = Console.ReadLine();
        if (ValidateInt(input1) == true && ValidateInt(input2) == true)
        {
          if (Convert.ToInt32(input1) <= HiveList.Count)
          {
            HiveList[Convert.ToInt32(input1) - 1].Collect(Convert.ToInt32(input2));
            return;
          }
        }
        else
        {
          if (Convert.ToInt32(input1) - 1 == HiveList.Count)
          {
            return;
          }
          Console.WriteLine(@"
Please ensure that you are entering a valid choice.
");
        }
      }
    }
    static List<Hive> AddHive(List<Hive> HiveList)
    {
      Console.WriteLine(@"
How many bees can the new hive contain?
");
      string input = Console.ReadLine();
      if (ValidateInt(input) == true)
      {
        var newHive = new Hive(Convert.ToInt32(input));
        HiveList.Add(newHive);
        foreach (Hive hive in HiveList)
        {
          hive.Report();
        }
        return HiveList;
      }
      else
      {
        Console.WriteLine(@"
Please ensure that you are entering a valid choice.
");
        return HiveList;
      }
    }

    static void AddBee(List<Hive> HiveList)
    {
      Console.Write(@"
Enter in a name for the bee:
    ");
      string newBeeName = Console.ReadLine();
      Console.Write(@"
Enter in a size for the bee:
    ");
      string newBeeSize = Console.ReadLine();
      try
      {
        Convert.ToSingle(newBeeSize);
      }
      catch (System.Exception)
      {
        return;
      }
      int counter = 1;
      Console.WriteLine(@"
Select which hive you wish to insert this bee into..
");
      foreach (Hive hive in HiveList)
      {
        Console.WriteLine(counter + ". Hive.");
        counter += 1;
      }
      Console.WriteLine(counter + ". Exit.");
      string hiveSelection = Console.ReadLine();
      if (ValidateInt(hiveSelection) == true)
      {
        if (Convert.ToInt32(hiveSelection) <= HiveList.Count)
        {
          var newBee = new Bee(newBeeName, Convert.ToSingle(newBeeSize));
          HiveList[Convert.ToInt32(hiveSelection) - 1].AddBee(newBee);
          return;
        }
        else if (Convert.ToInt32(hiveSelection) == HiveList.Count + 1)
        {
          return;
        }
      }
      else
      {
        Console.WriteLine(@"
    Please ensure that you are entering a valid choice.
    ");
      }
    }
    static void AddQueen(List<Hive> HiveList)
    {
      Console.Write(@"
Enter in a name for the queen:
    ");
      string newQueeName = Console.ReadLine();
      int counter = 1;
      Console.WriteLine(@"
Select which hive you wish to insert this queen into..
");
      foreach (Hive hive in HiveList)
      {
        Console.WriteLine(counter + ". Hive.");
        counter += 1;
      }
      Console.WriteLine(counter + ". Exit.");
      string hiveSelection = Console.ReadLine();
      if (ValidateInt(hiveSelection) == true)
      {
        if (Convert.ToInt32(hiveSelection) <= HiveList.Count)
        {
          var newQueen = new Queen(newQueeName);
          HiveList[Convert.ToInt32(hiveSelection) - 1].AddBee(newQueen);
          HiveList[Convert.ToInt32(hiveSelection) - 1].QueenList.Add(newQueen);
          return;
        }
        else if (Convert.ToInt32(hiveSelection) == HiveList.Count + 1)
        {
          return;
        }
      }
      else
      {
        Console.WriteLine(@"
    Please ensure that you are entering a valid choice.
    ");
      }
    }

    static bool ValidateInt(string input)
    {
      try
      {
        Convert.ToInt32(input);
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }
    }
  }
}


// I think that if i were to completely re-do this task i would move alot of the code into class methods
// I also realised later on that at some points in my code a format error can be made by entering in nothing which i would have to iron out.
// Also i ran out of time to put in a cvd file load and write for saving.