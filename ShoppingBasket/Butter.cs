using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class Butter : IProduct
    {
        public static string ProductName = "Butter"; 
        public string Name => ProductName;

        public decimal Price => 0.8M;
    }
}
