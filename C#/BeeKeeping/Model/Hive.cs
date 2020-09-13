using System;
using System.Collections.Generic;

namespace Bee_Keeping
{
  public class Hive
  {
    public int maxBees;
    public List<Queen> QueenList = new List<Queen>();
    public List<Bee> BeeList = new List<Bee>();
    public Hive(int maxBees)
    {
      this.maxBees = maxBees;
    }
    //Second consructor for hives with existing bees.
    public Hive(int maxBees, List<Bee> BeeList, List<Queen> QueenList)
    {
      this.maxBees = maxBees;
      this.BeeList = BeeList;
      this.QueenList = QueenList;
    }

    public void Collect(int days)
    {
      float totalHiveSize = 0;
      foreach (Bee bee in BeeList)
      {
        totalHiveSize += bee.size;
      }
      Console.WriteLine("Honey collected from {0} days of produce: {1}", days, days * 0.2 * totalHiveSize);
    }

    public void Report()
    {
      //counting bees
      int totalCount = 0;
      //total size
      float totalSize = 0f;

      foreach (Bee bee in BeeList)
      {
        Console.WriteLine("{0}, {1}", bee.name, bee.size);
        totalSize += bee.size;
        totalCount += 1;
      }
      Console.WriteLine("Total bee count: {0}", totalCount);
      Console.WriteLine("Total bee size: {0:0.0}", totalSize);
    }
    public void AddBee(Bee bee)
    {
      BeeList.Add(bee);
    }
  }
}