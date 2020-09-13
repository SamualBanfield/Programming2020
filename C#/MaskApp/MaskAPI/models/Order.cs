namespace MaskAPI.models
{
  public class Order
  {
    public int orderNo { get; set; }
    public Mask mask { get; set; }
    public int qty { get; set; }
    public double price { get; set; }

    public Order(Mask mask, int qty)
    {
      this.orderNo = this.GenerateOrderNo();
      this.mask = mask;
      this.qty = qty;
      this.SetPrice();
    }

    public void SetPrice()
    {
      this.price = this.qty * mask.cost;
    }

    public int GenerateOrderNo()
    {
      System.Random rand = new System.Random();
      return rand.Next(1000, 10000);
    }

  }
}