using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Create_Pastry()
    {
      Pastry Danish = new Pastry(3, 3);
      Assert.AreEqual(typeof(Pastry), Danish.GetType());
    }

    [TestMethod]
    public void Set_Pastry_Quantity_Get_Quantity()
    {
      int QuantityOfPastry = 20;
      Pastry Danish = new Pastry(3, QuantityOfPastry); 
      Assert.AreEqual(QuantityOfPastry, Danish.getQuantity());
    }

    [TestMethod]
    public void Set_Pastry_Price_Get_Price()
    {
      int PriceOfPastry = 3;
      Pastry Danish = new Pastry(PriceOfPastry, 20); 
      Assert.AreEqual(PriceOfPastry, Danish.getIndividualPrice());
    }

    [TestMethod]
    public void Set_Pastry_Discounted_Price()
    {
      double discountMultiplier = .80;
      Pastry Danish = new Pastry (5, 5);

      Danish.pastryDiscount(discountMultiplier);

      Assert.AreEqual(4, Danish.PastryPrice); 
    }

    [TestMethod]
    public void Get_Total_Pastry_Price()
    {
      Pastry Danish = new Pastry(5, 5);

      Assert.AreEqual(25, Danish.getTotalPastryPrice());
    }

    [TestMethod]
    public void Set_Pastry_Discounted_Price_Get_Total_Discounted_Pastry_Price()
    {
      double discountMultiplier = .80;
      Pastry Danish = new Pastry (5, 5);

      Danish.pastryDiscount(discountMultiplier);

      Assert.AreEqual(20, Danish.getTotalPastryPrice()); 
    }
  }
}