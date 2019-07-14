using System;
using System.Collections.Generic;

namespace CheckoutChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //startup
            //create items
            /*  Item Name		Price		Special Price
                A				50p			3 for £1.30
                B				30p			2 for £0.45
                C 				70p			
                D				20p*/
            Stock.AvailableItems = new List<Item>
            {
                new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)),
                new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)),
                new Item('C', 0.7),
                new Item('D', 0.2)
            };

            Checkout checkout = new Checkout();

            ConsoleKeyInfo cki;
            Console.WriteLine("Please enter A, B, C or D to add an item to your basket.");
            Console.WriteLine("Press Enter to finish and receive the total: \n");
            do
            {
                cki = Console.ReadKey();

                checkout.AddItemToCheckout(Stock.AvailableItems.Find(item => item.Name.ToString() == cki.Key.ToString()));

            } while (cki.Key != ConsoleKey.Enter);

            var totalPrice = checkout.GetTotal();

            Console.WriteLine($"Total = {totalPrice}");

            Console.Read();
        }

    }
}
