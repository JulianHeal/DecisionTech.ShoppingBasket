using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    /// <summary>
    /// creates products, in practice this would be a repository reading a list of available products from persistent storage
    /// </summary>
    public class ProductFactory :IProductFactory
    {
        public IProduct GetProduct(string name)
        {
            if (string.Compare(name, Milk.ProductName, true) == 0)
                return new Milk();
            if (string.Compare(name, Bread.ProductName, true) == 0)
                return new Bread();
            if (string.Compare(name, Butter.ProductName, true) == 0)
                return new Butter();

            throw new Exception($"Product can not be created because product is unknown: {name}");
        }
    }
}
