using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasket.Tests
{
    [TestClass]
    public class ProductFactoryTests
    {
        [TestMethod]
        public void InvalidProductRaisesExceptionTest()
        {
            var productFactory = new ProductFactory();
            Assert.ThrowsException<Exception>(() => productFactory.GetProduct("qwe"));
        }
    }
}
