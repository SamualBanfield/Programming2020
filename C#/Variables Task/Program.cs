// S.Banfield
// 25/02/2020
// Simple program to introduce variables.

using System;

namespace Programming2020
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("First Name: ");
      string firstName = Console.ReadLine();

      Console.WriteLine("last Name: ");
      string lastName = Console.ReadLine();

      Console.WriteLine("Student ID: ");
      int studentId = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Year of Birth: ");
      int birthYear = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Current Year: ");
      int currentYear = Convert.ToInt32(Console.ReadLine());

      int age = currentYear - birthYear - 1;

      Console.WriteLine($"{firstName} {lastName},\n You are at least { age} years old.");
    }
  }
}
