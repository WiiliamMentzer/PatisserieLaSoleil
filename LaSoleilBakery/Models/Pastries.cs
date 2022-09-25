using System.Collections.Generic;
namespace Bakery.Dough {

  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set;}

    public void SetQuantity(int quantity)
    {
      BreadQuantity = quantity;
    }
  }

  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryQuantity { get; set;}
  }
}