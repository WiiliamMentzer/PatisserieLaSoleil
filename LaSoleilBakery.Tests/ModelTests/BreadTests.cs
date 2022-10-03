using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Create_Bread()
    {
      Bread Sourdough = new Bread(3, 3);
      Assert.AreEqual(typeof(Bread), Sourdough.GetType());
    }

    [TestMethod]
    public void Set_Bread_Price_Get_Price()
    {
      int PriceOfBread = 3;
      Bread Sourdough = new Bread (PriceOfBread, 20); 
      Assert.AreEqual(PriceOfBread, Sourdough.getIndividualPrice());
    }

    [TestMethod]
    public void Set_Bread_Quantity_Get_Quantity()
    {
      int QuantityOfBread = 20;
      Bread Sourdough = new Bread(3, QuantityOfBread); 
      Assert.AreEqual(QuantityOfBread, Sourdough.getQuantity());
    }

    [TestMethod]
    public void Set_Bread_Discounted_Price()
    {
      double discountMultiplier = .80;
      Bread Sourdough = new Bread (5, 5);

      Sourdough.breadDiscountByDecimal(discountMultiplier);

      Assert.AreEqual(4, Sourdough.BreadPrice); 
    }

    [TestMethod]
    public void Get_Total_Bread_Price()
    {
      Bread Sourdough = new Bread(5, 5);

      Assert.AreEqual(25, Sourdough.getTotalBreadPrice());
    }

    [TestMethod]
    public void Set_Bread_Discounted_Price_By_Decimal_Get_Total_Discounted_Bread_Price()
    {
      double discountMultiplier = .80;
      Bread Sourdough = new Bread (5, 5);

      Sourdough.breadDiscountByDecimal(discountMultiplier);

      Assert.AreEqual(20, Sourdough.getTotalBreadPrice()); 
    }

    [TestMethod]
    public void Set_Bread_Discounted_Price_Get_Total_Discounted_Bread_Price()
    {
      Bread Sourdough = new Bread (5, 5);

      Sourdough.breadDiscount();

      Assert.AreEqual(20, Sourdough.BreadTotalCost); 
    }
  }
}