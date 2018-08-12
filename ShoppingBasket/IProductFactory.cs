using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    public interface IProductFactory
    {
        IProduct GetProduct(string name);
    }
}
