using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryQuantity { get; set; }

    public Pastry(int price, int quantity)
    {
      PastryPrice = price;
      PastryQuantity = quantity;
    }

    public void SetQuantity(int quantity)
    {
      PastryQuantity = quantity;
    }

    public void SetPrice(int price)
    {
      PastryPrice = price;
    }

    public int GetPrice()
    {
      return PastryPrice;
    }
    
  }
}