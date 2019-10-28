using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Models
{
    public class Bread : IProduct
    {
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
