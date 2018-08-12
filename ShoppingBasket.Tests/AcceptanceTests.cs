using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasket.Tests
{

    //these tests were drawn directly from the excercise
    [TestClass]
    public class AcceptanceTests
    {
        [TestMethod]
        public void TestBasketTotaling()
        {
            IBasket basket = new Basket();
            IBasket basketWithBreadOffer = new BasketWithBreadOffer(basket);
            IBasket sut = new BasketWithMilkOffer(basketWithBreadOffer);
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
            IBasket basketWithBreadOffer = new BasketWithBreadOffer(basket);
            IBasket sut = new BasketWithMilkOffer(basketWithBreadOffer);
            var productFactory = new ProductFactory();

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));

            Assert.AreEqual(3.10M, sut.Total);
        }

        [TestMethod]
        public void BasketWith4MilkTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket basketWithBreadOffer = new BasketWithBreadOffer(basket);
            IBasket sut = new BasketWithMilkOffer(basketWithBreadOffer);

            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(3.45M, sut.Total);
        }

        [TestMethod]
        public void BasketWith8Milk2Butter1BreadTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket basketWithBreadOffer = new BasketWithBreadOffer(basket);
            IBasket sut = new BasketWithMilkOffer(basketWithBreadOffer);

            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Milk"));
            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Butter"));

            Assert.AreEqual(9.00M, sut.Total);
        }
    }
}
