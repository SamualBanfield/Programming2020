using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Guess_the_Number
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      int answer = (rand.Next(1, 25));
      Console.WriteLine(answer);
      Console.WriteLine(@"
Hello, Welcome to the Guess the number.
You must guess a number im thinking of between 1 - 25.
And you have 7 guesses to do so.
");
      int turnCounter = 0;
      bool play = true;
      List<string> priorGuesses = new List<string>();
      while (play == true)
      {
        if (turnCounter < 7)
        {
          //Making and verifying guesss
          string stringGuess = guess();
          turnCounter += 1;
          priorGuesses.Add($"{stringGuess},");
          Console.WriteLine(@"
Your guess was...
        ");
          Thread.Sleep(2000);
          if (Convert.ToInt32(stringGuess) == answer)
          {
            Console.WriteLine($@"          
      Correct!!!

You managed to guess the Number in {turnCounter} guesses.
Your guesses were... 
  ");
            priorGuesses.ForEach(Console.Write);
            play = false;
          }
          else
          {
            Console.WriteLine($@"          
      Incorrect...
");
            if (Convert.ToInt32(stringGuess) > answer)
            {
              Console.WriteLine("The number you seek is LOWER.");
            }
            else
            {
              Console.WriteLine("The number you seek is HIGHER.");
            }
            Console.WriteLine($@"
Your current guesses are..
");
            priorGuesses.ForEach(Console.Write);
            Console.WriteLine($@"
You have {7 - turnCounter} guesses left.
          ");
          }
        }
        else
        {
          Console.WriteLine($@" 
The answer was {answer}     
Unfortunately you were unable to guess the number in the correct window of guesses...
");
        }
      }
      Console.ReadKey();
    }

    static string guess()
    {
      Console.Write("Guess a number: ");
      // string stringGuess = Console.ReadLine();
      string stringGuess = Console.ReadLine();
      return stringGuess;
    }
  }
}
