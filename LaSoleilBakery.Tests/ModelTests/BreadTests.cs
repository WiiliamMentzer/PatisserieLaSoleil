using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void Create_Bread_Quantity()
    {
      Bread chibata = new Bread(3, 3);
      Assert.AreEqual(typeof(Bread), chibata.GetType());
    }

  }
}