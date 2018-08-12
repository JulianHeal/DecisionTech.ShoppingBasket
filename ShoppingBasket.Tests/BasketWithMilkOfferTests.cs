using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasket.Tests
{
    [TestClass]
    public class BasketWithMilkOfferTests
    {
        [TestMethod]
        public void BasketWithNoDiscountTest()
        {
            var productFactory = new ProductFactory();
            IBasket basket = new Basket();
            IBasket basketWithBreadOffer = new BasketWithBreadOffer(basket);
            IBasket sut = new BasketWithMilkOffer(basketWithBreadOffer);

            sut.AddProduct(productFactory.GetProduct("Butter"));
            sut.AddProduct(productFactory.GetProduct("Bread"));
            sut.AddProduct(productFactory.GetProduct("Milk"));

            Assert.AreEqual(2.95M, sut.Total);
        }
    }
}
