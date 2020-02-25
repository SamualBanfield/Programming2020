using System;

namespace Programming2020
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("First Name: ");
      string firstName = Console.ReadLine();

      Console.WriteLine("Second Name: ");
      string secondName = Console.ReadLine();

      Console.Write("Hello " + firstName + " " + secondName);
    }
  }
}
