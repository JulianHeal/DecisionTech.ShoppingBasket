using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasket.Tests
{
    [TestClass]
    public class AcceptanceTests
    {
        [TestMethod]
        public void TestBasketTotaling()
        {
            IBasket basket = new Basket();
            var productFactory = new ProductFactory();

            basket.AddProduct(productFactory.GetProduct("Butter"));
            basket.AddProduct(productFactory.GetProduct("Bread"));
            basket.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(2.95M, basket.Total);
        }
    }
}
