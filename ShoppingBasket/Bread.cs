using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class Bread : IProduct
    {
        public static string ProductName = "Bread";
        public string Name  => ProductName;
        public decimal Price => 1;
    }
}
