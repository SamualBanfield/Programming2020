using System;

namespace Functions_and_Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      for (; ; )
      {
        Console.Write("Enter in Task number between 1 - 12. Anything else will terminate: ");
        int selection = Convert.ToInt32(Console.ReadLine());
        switch (selection)
        {
          case 1:
            hello();
            break;
          case 2:
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            helloUser(name);
            break;
          case 3:
            Console.WriteLine();
            Console.Write("Enter in a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter in another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = " + simpleAdd(num1, num2));
            break;
          case 4:
            Console.WriteLine();
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("'{0}' contain {1} spaces", input, countSpaces(input));
            break;
          case 5:
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {

            }
            break;
          case 6:
            break;
          case 7:
            break;
          case 8:
            break;
          case 9:
            break;
          case 10:
            break;
          case 11:
            break;
          case 12:
            break;
          default:
            System.Environment.Exit(0);
            break;
        }
      }
    }
    static void hello()
    {
      Console.Write(@"
Welcome Friends! 
Have a nice day!

"
      );
    }
    static void helloUser(string name)
    {
      Console.Write($@"
Welcome friend {name}! 
Have a nice day!

"
      );
    }
    static int simpleAdd(int num1, int num2)
    {
      return num1 + num2;
    }
    static int countSpaces(string input)
    {
      int count = 0;
      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] == ' ')
        {
          count += 1;
        }
      }
      return count;
    }
  }
}
