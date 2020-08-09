using System;
using System.Collections.Generic;

namespace D_D_Dice
{
  class Program
  {
    static void Main(string[] args)
    {
      var rnd = new Random();
      var d6 = new Die(6);
      var d4 = new Die(6);
      var StevesDice = new List<Die>();
      StevesDice.Add(d6);
      StevesDice.Add(d4);
      var Steve = new player("Steve", StevesDice);
    }

    public class Die
    {
      public int sides;
      public Die(int argSides)
      {
        argSides = sides;
      }

      public int roll()
      {
        return 0;
      }
    }
    public class Player
    {
      public string name;
      public List<Die> Dice;
      public Player(string name, List<Die> dice)
      {
        this.name = name;
        this.Dice = Dice;
      }
      public int rollDice(int die)
      {
        return 0;
      }
    }
  }
}
