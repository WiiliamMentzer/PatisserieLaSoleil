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
      Assert.AreEqual(PriceOfBread, Sourdough.GetPrice());
    }

  }
}