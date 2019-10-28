using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShoppingBasket
{
    public class Discount<T>: IDiscount
    {
        //Koliko mora kupit da ostvari popust
        public int Amount { get; set; }

        public double DiscountPercentage { get; set; }

        //na svako koji dobiva popust
        public int Offset { get; set; }

        public double Apply(IProduct product) 
        {
            var test = product.Amount / Amount;
            return product.Amount >= Amount ?
                product.Amount * product.Price - ( (product.Amount / Amount - Offset) * product.Price) * (DiscountPercentage / 100) :
                product.Amount * product.Price;
            //var t = (product.Amount % Amount) / (product.Amount * product.Price);
            //var z = (product.Amount % Amount);
            //switch (Type)
            //{
            //    case DiscountType.Percentage:
            //        return product.Amount >= Amount ? 
            //            product.Amount * product.Price * (DiscountPercentage / 100) :
            //            product.Amount * product.Price;
            //    case DiscountType.PlusOne:
            //        return product.Amount >= Amount ?
            //            product.Amount * product.Price - (product.Amount % Amount) / (product.Amount * product.Price):
            //            product.Amount * product.Price;
            //    default:
            //        return product.Amount * product.Price;
            //}
        }
    }

    public enum DiscountType 
    {
        PlusOne,
        Percentage
    }
}
