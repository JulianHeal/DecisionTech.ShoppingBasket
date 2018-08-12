using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasket.Tests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void EmptyBasketTest()
        {
            var emptyBasket = new Basket();

            Assert.AreEqual(0, emptyBasket.Total);
        }
    }
}
