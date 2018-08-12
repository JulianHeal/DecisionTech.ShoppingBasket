using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasket.Tests
{
    [TestClass]
    public class BasketWithBreadOfferTests
    {
        [TestMethod]
        public void BasketWithBreadOfferNoDiscountTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket sut = new BasketWithBreadOffer(basket);

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(2.95M, sut.Total);
        }

        [TestMethod]
        public void BasketWithBreadOfferOneDiscountTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket sut = new BasketWithBreadOffer(basket);

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(3.25M, sut.Total);
        }

        [TestMethod]
        public void BasketWithBreadOfferTwoDiscountTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket sut = new BasketWithBreadOffer(basket);

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(5.35M, sut.Total);
        }

        [TestMethod]
        public void BasketWithBreadOfferOneDiscountButTwoPossibleDiscountsTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket sut = new BasketWithBreadOffer(basket);

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(4.85M, sut.Total);
        }

        [TestMethod]
        public void BasketWith3BreadAnd4ButterTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket sut = new BasketWithBreadOffer(basket);

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Bread"));

            Assert.AreEqual(5.20M, sut.Total);
        }
    }
}
