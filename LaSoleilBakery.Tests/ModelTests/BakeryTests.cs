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
}