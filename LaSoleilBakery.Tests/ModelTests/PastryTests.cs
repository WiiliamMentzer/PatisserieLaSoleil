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
    public void Set_Pastry_Price_Get_Price()
    {
      int PriceOfPastry = 3;
      Pastry Danish = new Pastry(PriceOfPastry, 20); 
      Assert.AreEqual(PriceOfPastry, Danish.GetPrice());
    }

  }
}