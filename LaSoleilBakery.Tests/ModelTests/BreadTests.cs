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
    public void Create_Bread()
    {
      Bread chibata = new Bread();
      Assert.AreEqual(typeof(Bread), chibata.GetType());
    }

  }
}