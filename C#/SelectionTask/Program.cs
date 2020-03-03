// S.Banfield
// 25/02/2020
// Simple program to introduce selection statements.

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SelectionTask
{
  class PasswordCheck
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Username: ");
      string userName = Console.ReadLine();

      Console.WriteLine("Password: ");
      string passWord = Console.ReadLine();
      // referencing another method to check a csv file for a username and password
      if (checking(userName, passWord) == true)
      {
        Console.WriteLine("Login succesful!");
      }
      else
      {
        Console.WriteLine("Login unsuccesful!");
      }
      Console.ReadKey();
    }

    static bool checking(string userName, string passWord)
    {
      string filepath = @"C:\Users\Sam\Desktop\Vis Code\School\Programming2020\C#\SelectionTask\currentUserInfo.csv";
      List<string> lines = File.ReadAllLines(filepath).ToList();
      // Putting Each line into arrays based on commas
      foreach (string line in lines)
      {
        foreach (char character in line)
        {
          string variablecheck = "";
          if (character == ',')
          {

          }
          variablecheck.Append(character);
        }
        Console.WriteLine(" ");
        string StringCheck = "";
      }
      return false;
    }
  }
}
