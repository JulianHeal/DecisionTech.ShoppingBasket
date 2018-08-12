using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class Milk : IProduct
    {
        public static string ProductName = "Milk";
        public string Name => ProductName;
        public decimal Price => 1.15M;
    }
}
