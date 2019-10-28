using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    public interface IProduct
    {
        double Price { get; set; }

        int Amount { get; set; }
    }
}
