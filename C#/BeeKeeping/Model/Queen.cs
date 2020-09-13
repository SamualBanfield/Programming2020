namespace Bee_Keeping
{
  public class Queen : Bee
  {
    public Queen(string name)
    : base(name, 0f)
    {
      this.name = name;
      this.size = 0f;
    }
    public void MakeBee(Hive Hive)
    {
      var newBee = new Bee(("Spawn of " + name), 0.1f);
      Hive.AddBee(newBee);
    }
  }
}
