namespace MaskAPI.models
{
  public class Mask
  {
    public string maskId { get; set; }
    public int size { get; set; }
    public string colour { get; set; }
    public bool New { get; set; }
    public bool preInfected { get; set; }
    public string design { get; set; }
    public double cost { get; set; }

    public Mask(string maskId, int size, string colour, bool @new, bool preInfected, string design, double cost)
    {
      this.maskId = maskId;
      this.size = size;
      this.colour = colour;
      New = @new;
      this.preInfected = preInfected;
      this.design = design;
      this.cost = cost;
    }
  }
}