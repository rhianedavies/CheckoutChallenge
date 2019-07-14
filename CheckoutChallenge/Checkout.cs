using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class Checkout
    {
        public List<Item> ItemsInCheckout { get; set; }

        public void AddItemToCheckout(Item itemToAdd)
        {
            PriceForNumberOfItems p = new PriceForNumberOfItems(itemToAdd.SpecialPrice.NoOfItems, itemToAdd.SpecialPrice.GroupPrice);
            ItemsInCheckout.Add(new Item(itemToAdd.Name, itemToAdd.Price, p));
        }

        public double GetTotal()
        {
            double total = 0;
            //int noOfA = ItemsInCheckout.Where(item => item.Name == 'A').Count();
            //total += GetPrice(stock.AvailableItems.Find(item => item.Name.ToString() == 'A', noOfA);
            //int noOfB = ItemsInCheckout.Where(item => item.Name == 'B').Count();
            //total += GetPrice('B', noOfB);
            //int noOfC = ItemsInCheckout.Where(item => item.Name == 'C').Count();
            //total += GetPrice('C', noOfC);
            //int noOfD = ItemsInCheckout.Where(item => item.Name == 'D').Count();
            //total += GetPrice('D', noOfD);
            return total;
        }
    }
}
