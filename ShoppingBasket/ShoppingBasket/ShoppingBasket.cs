using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingBasket
{
    public class ShoppingBasket
    {
        ICollection<IProduct> Products { get; set; }

        ICollection<IDiscount> Discounts { get; set; }

        public ShoppingBasket()
        {
            Products = new List<IProduct>();

            Discounts = new List<IDiscount>();
        }

        public void Add(IProduct product) 
        {
            Products.Add(product);
        }

        public void Add(IDiscount discount) 
        {
            Discounts.Add(discount);
        }

        public double GetPrice() 
        {
            double price = 0;

            foreach (var product in Products)
            {
                var discount = Discounts.FirstOrDefault(x => x.GetType().GenericTypeArguments.First() == product.GetType());

                if (discount == null)
                    price += product.Amount * product.Price;
                else
                    price += discount.Apply(product);
            }

            return price;
        }
    }
}
