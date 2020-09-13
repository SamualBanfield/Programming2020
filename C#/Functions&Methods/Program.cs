using System;
using System.Collections.Generic;

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
              Console.WriteLine();
              Console.Write("Enter in a number: ");
              array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the array is {0}", arrayAdd(array));
            break;
          case 6:
            Console.WriteLine();
            Console.Write("Enter in a number: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter in another number: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            (int1, int2) = swapInts(int1, int2);
            Console.WriteLine($"Now the 1st number is {int1} and the second number is {int2}");
            break;
          case 7:
            Console.WriteLine();
            Console.Write("Enter in a base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter in exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number {0} ^ {1} = {2}", baseNum, exponent, powerOf(baseNum, exponent));
            break;
          case 8:
            Console.WriteLine();
            Console.Write("Enter in the length of fibonacci you wish to display: ");
            int sequenceLen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibonacci sequence for {0} numbers is:", sequenceLen);
            Console.WriteLine(String.Join(", ", fibonacci(sequenceLen)));
            Console.WriteLine();
            break;
          case 9:
            Console.WriteLine();
            Console.Write("Enter in a number: ");
            int primeNum = Convert.ToInt32(Console.ReadLine());
            bool primeBool = primeCheck(primeNum);
            if (primeBool == true)
            {
              Console.WriteLine("{0} is a prime number!", primeNum);
            }
            if (primeBool == false)
            {
              Console.WriteLine("{0} is not a prime number!", primeNum);
            }
            break;
          case 10:
            Console.WriteLine();
            Console.Write("Enter in a number: ");
            int sumNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("'{0}' sum = {1}", sumNumber, sumOfNum(sumNumber));
            break;
          case 11:
            Console.WriteLine();
            Console.Write("Enter in a number: ");
            int factorialNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} factorial = {1}", factorialNum, factorial(factorialNum));
            break;
          case 12:
            Console.WriteLine();
            Console.Write("Enter in a number: ");
            int fibonacciPosition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibonacci of the term {0} is: {1}", fibonacciPosition, fibonacciP(fibonacciPosition));
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
    static int arrayAdd(int[] array)
    {
      int counter = 0;
      foreach (int num in array)
      {
        counter += num;
      }
      return counter;
    }
    static Tuple<int, int> swapInts(int int1, int int2)
    {
      (int1, int2) = (int2, int1);
      return Tuple.Create(int1, int2);
    }
    static double powerOf(int baseNum, int exponent)
    {
      return Math.Pow(baseNum, exponent);
    }
    static List<int> fibonacci(int sequenceLen)
    {
      List<int> sequence = new List<int>();
      for (int i = 0; i < sequenceLen; i++)
      {
        try
        {
          sequence.Add(sequence[i - 1] + sequence[i - 2]);
        }
        catch
        {
          sequence.Add(i);
        }
      }
      return sequence;
    }
    static bool primeCheck(int n)
    {
      if (n <= 3)
      {
        return n > 1;
      }
      else if ((n % 2 == 0) || (n % 3 == 0))
      {
        return false;
      }
      for (int i = 5; i * i <= n;)
      {
        if ((n % i == 0) || (n % (i + 2) == 0))
        {
          return false;
        }
        i += 6;
      }
      return true;
    }
    static double sumOfNum(int n)
    {
      string stringN = n.ToString();
      Console.WriteLine(stringN);
      double total = 0;
      for (int i = 0; i < stringN.Length; i++)
      {
        total += Char.GetNumericValue(stringN[i]);
      }
      return total;
    }
    static int factorial(int n)
    {
      int total = n;
      for (int i = n - 1; i > 0; i--)
      {
        total *= i;
      }
      return total;
    }
    static int fibonacciP(int position)
    {
      List<int> sequence = new List<int>();
      for (int i = 0; i < position; i++)
      {
        try
        {
          sequence.Add(sequence[i - 1] + sequence[i - 2]);
        }
        catch
        {
          sequence.Add(i);
        }
      }
      return sequence[sequence.Count - 1];
    }
  }
}
