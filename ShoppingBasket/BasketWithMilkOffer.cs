using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingBasket
{
    public class BasketWithMilkOffer : IBasket
    {
        private IBasket basket;

        public BasketWithMilkOffer(IBasket basket)
        {
            this.basket = basket;
        }

        public decimal Total
        {
            get
            {
                decimal milks = Contents.Count(p => string.Compare(p.Name, Milk.ProductName, true) == 0);

                if(milks < 4)
                {
                    return basket.Total;
                }

                var freeMilks = Math.Floor(milks / 4);
                var milkPrice = Contents.First(p => string.Compare(p.Name, Milk.ProductName, true) == 0).Price;
                return basket.Total - freeMilks * milkPrice;
            }
        }

        

        public IEnumerable<IProduct> Contents => this.basket.Contents;

        public void AddProduct(IProduct product)
        {
            this.basket.AddProduct(product);
        }
    }
}
