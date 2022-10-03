using System.Collections.Generic;
using System;

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

    public void setQuantity(int quantity)
    {
      BreadQuantity = quantity;
    }

    public void setPrice(int price)
    {
      BreadPrice = price;
    }

    public int getIndividualPrice()
    {
      return BreadPrice;
    }

    public int getTotalBreadPrice()
    {
      return BreadQuantity * BreadPrice;
    }

    public int getQuantity()
    {
      return BreadQuantity;
    }

    public double breadDiscount(double discount)
    { 
      double afterDiscount = BreadPrice * discount;
      BreadPrice = Convert.ToInt32(afterDiscount);
      return BreadPrice;
    }
  }
}