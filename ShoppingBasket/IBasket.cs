using System.Collections.Generic;

namespace ShoppingBasket
{
    public interface IBasket
    {
        decimal Total { get; }

        void AddProduct(IProduct product);

        IEnumerable<IProduct> Contents { get; }
    }
}