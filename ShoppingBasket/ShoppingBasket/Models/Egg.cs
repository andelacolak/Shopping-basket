using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Models
{
    public class Egg: IProduct
    {
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
