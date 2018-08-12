using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingBasket
{
    public class Basket : IBasket
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public decimal Total
        {
            get
            {
                return products.Sum(p => p.Price);
            }
        }

        public IEnumerable<IProduct> Contents => products;
    }
}
