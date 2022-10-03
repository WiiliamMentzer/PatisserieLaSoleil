using System.Collections.Generic;
using System;

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

    public void setQuantity(int quantity)
    {
      PastryQuantity = quantity;
    }

    public void setPrice(int price)
    {
      PastryPrice = price;
    }

    public int getIndividualPrice()
    {
      return PastryPrice;
    }

    public int getTotalPastryPrice()
    {
      return PastryQuantity * PastryPrice;
    }

    public int getQuantity()
    {
      return PastryQuantity;
    }

    public double pastryDiscount(double discount)
    { 
      double afterDiscount = PastryPrice * discount;
      PastryPrice = Convert.ToInt32(afterDiscount);
      return PastryPrice;
    }
    
  }
}