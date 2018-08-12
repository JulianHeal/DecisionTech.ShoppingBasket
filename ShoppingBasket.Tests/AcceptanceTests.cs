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
            var sut = new BasketWithBreadOffer(basket);
            var productFactory = new ProductFactory();

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(2.95M, basket.Total);
        }

        [TestMethod]
        public void TestBasketTotalingWith2BreadsAnd2Butters()
        {
            IBasket basket = new Basket();
            var sut = new BasketWithBreadOffer(basket);
            var productFactory = new ProductFactory();

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));

            Assert.AreEqual(3.10M, sut.Total);
        }
    }
}
