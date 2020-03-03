using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Largest_in_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      string filepath = @"C:\Users\Sam\Desktop\Vis Code\School\Programming2020\C#\Challanges\Largest in Array\Array.txt"
      int[] intarray = File.ReadAllLines().ToArray;
      Console.WriteLine(intarray);
    }
  }
}
