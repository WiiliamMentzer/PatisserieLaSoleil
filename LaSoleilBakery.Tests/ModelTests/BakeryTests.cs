using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Dough;

namespace Bakery.Dough
{
  [TestClass]
  public class Bread
  {

    [TestMethod]
    public void Create_Bread_Quantity()
    {
      Bread chibata = new Bread();
      Assert.AreEqual(typeof(Bread), chibata.GetType());
    }

  }

  [TestClass]
  public class Pastry
  {

    [TestMethod]
    public void Create_Pastry_Quantity()
    {
      Pastry Danish = new Pastry();
      Assert.AreEqual(typeof(Pastry), Danish.GetType());
    }

    public void Set_Pastry_Price()
    {
      Pastry Danish = new Pastry(3, 3); 
      Assert.AreEqual(3, Danish.GetPrice());
    }

  }
}