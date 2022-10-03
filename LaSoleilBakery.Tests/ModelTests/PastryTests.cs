using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class Pastry
  {
    [TestMethod]
    public void Create_Pastry_Quantity()
    {
      Pastry Danish = new Pastry(3, 3);
      Assert.AreEqual(typeof(Pastry), Danish.GetType());
    }

    // [TestMethod]
    // public void Set_Pastry_Price()
    // {
    //   Pastry Danish = new Pastry(3, 3); 
    //   Assert.AreEqual(3, Danish.GetPrice());
    // }

  }
}