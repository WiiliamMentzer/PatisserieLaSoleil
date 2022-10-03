using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set;}

    public Bread(int price, int quantity)
    {
      BreadPrice = price;
      BreadQuantity = quantity;
    }

    public void SetQuantity(int quantity)
    {
      BreadQuantity = quantity;
    }

    public void setPrice(int price)
    {
      BreadPrice = price;
    }
  }
}