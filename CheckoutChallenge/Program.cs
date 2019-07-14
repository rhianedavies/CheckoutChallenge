using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Stock stock = new Stock();
            stock.AvailableItems = new List<Item>
            {
                new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)),
                new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)),
                new Item('C', 0.7),
                new Item('D', 0.2)
            };

            Checkout checkout = new Checkout();

            ConsoleKeyInfo cki;
            Console.WriteLine("Please enter A, B, C or D to add an item to your basket.");
            Console.WriteLine("Press Enter to finish and receive the sum: \n");
            do
            {
                cki = Console.ReadKey();

                checkout.AddItemToCheckout(stock.AvailableItems.Find(item => item.Name.ToString() == cki.Key.ToString()));

                //foreach (var availableItem in availableItems)
                //{
                //    if (cki.Key.ToString() == availableItem.Name.ToString())
                //    {
                //        itemsInBasket.Add(cki.KeyChar);
                //    }
                //}
                //Console.Write(" --- You pressed ");
                //Console.WriteLine(cki.Key.ToString());
                //string strBasket = "";
                //foreach (var itemInBasket in itemsInBasket)
                //{
                //    strBasket += itemInBasket.ToString().ToUpper() + " ";
                //}
                //Console.WriteLine($"In Basket: {strBasket}");
            } while (cki.Key != ConsoleKey.Enter);

            var totalPrice = checkout.GetTotal();

            Console.WriteLine($"Total = {totalPrice}");
        }

        //private bool CompareKeyCharAndChar(ConsoleKeyInfo keyChar, char nameChar)
        //{
        //    keyChar.Modifiers
        //    return false;
        //}
    }
}
