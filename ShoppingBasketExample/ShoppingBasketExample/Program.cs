using System;
using ShoppingBasket;
using ShoppingBasket.Models;

namespace ShoppingBasketExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingBasket = new ShoppingBasket.ShoppingBasket();

            var bread = new Bread { Price = 1, Amount = 6};

            var eggs = new Egg { Price = 0.8, Amount = 2 };

            //Every third bread is 50 % off
            Discount<Bread> breadDiscount = new Discount<Bread>
            {
                Amount = 2,
                DiscountPercentage = 50,
                Offset = 1
            };

            //Every bread is 50 % off
            Discount<Bread> breadDiscount2 = new Discount<Bread>
            {
                Amount = 1,
                DiscountPercentage = 50,
                Offset = 0
            };

            //Discount<Bread> breadDiscount = new Discount<Bread>
            //{
            //    Amount  = 2,
            //    DiscountPercentage = 100,
            //};

            shoppingBasket.Add(bread);

            shoppingBasket.Add(breadDiscount2);

            Console.WriteLine("Test");

            Console.WriteLine($"Total price: {shoppingBasket.GetPrice().ToString()}");

            Console.ReadKey();
        }
    }
}
