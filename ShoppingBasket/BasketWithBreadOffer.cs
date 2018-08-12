using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingBasket
{
    public class BasketWithBreadOffer : IBasket
    {
        private IBasket basket;

        public BasketWithBreadOffer(IBasket basket)
        {
            this.basket = basket;
        }

        public decimal Total
        {
            get
            {
                decimal butters = Contents.Count(p => string.Compare(p.Name, Butter.ProductName, true) == 0);

                if (butters <= 1)
                {
                    return basket.Total;
                }

                var halfPriceBreads = GetPotentialHalfPriceBreads(butters);
                decimal breadsToDiscount = GetBreadCount();
                decimal discounts = GetNumberOfDiscountsToApply(halfPriceBreads, breadsToDiscount);
                decimal totalDiscount = discounts * GetBreadDiscount();
                return basket.Total - totalDiscount;
            }
        }

        private static decimal GetPotentialHalfPriceBreads(decimal butters)
        {
            return Math.Floor(butters / 2);
        }

        private static decimal GetNumberOfDiscountsToApply(decimal potentialHalfPriceBreads, decimal breads)
        {
            //whichever is the lower of the breads actually bought and the potential half price breads
            if (breads > potentialHalfPriceBreads)
                return potentialHalfPriceBreads;
            else
                return breads;
        }

        private decimal GetBreadCount()
        {
            return Contents.Count(p => string.Compare(p.Name, Bread.ProductName, true) == 0);
        }

        private decimal GetBreadDiscount()
        {
            var bread = Contents.First(p => string.Compare(p.Name, Bread.ProductName, true) == 0);
            return bread.Price / 2;
        }

        public IEnumerable<IProduct> Contents => basket.Contents;

        public void AddProduct(IProduct product)
        {
            basket.AddProduct(product);
        }
    }
}
