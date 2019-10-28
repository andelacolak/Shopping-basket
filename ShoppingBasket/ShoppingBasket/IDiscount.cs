using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    //Da ne moran odma rec type
    public interface IDiscount
    {
        //How many one has to buy to have a discount
        int Amount { get; set; }

        //Every third free
        int Offset { get; set; }

        //How much off is the product
        double DiscountPercentage { get; set; }

        double Apply(IProduct products);
    }
}
