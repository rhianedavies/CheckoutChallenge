using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class Checkout
    {
        Dictionary<char, int> checkoutContents = new Dictionary<char, int>();

        public void AddItemToCheckout(Item itemToAdd)
        {
            if (itemToAdd != null)
            {
                if (checkoutContents.ContainsKey(itemToAdd.Name))
                {
                    checkoutContents[itemToAdd.Name] += 1;
                }
                else
                {
                    checkoutContents.Add(itemToAdd.Name, 1);
                }
            }

        }
        public double GetPrice(string name, int noOfItems)
        {
            double price = 0;
            Item anItem = Stock.AvailableItems.Find(item => item.Name.ToString() == name);
            if (anItem.SpecialPrice != null)
            {
                if (noOfItems >= anItem.SpecialPrice.NoOfItems)
                {
                    price = noOfItems / anItem.SpecialPrice.NoOfItems * anItem.SpecialPrice.GroupPrice;
                    noOfItems = noOfItems - noOfItems / anItem.SpecialPrice.NoOfItems;
                }
            }

            price += (noOfItems * anItem.Price);
            return price;
        }

        public double GetTotal()
        {
            double total = 0;
            checkoutContents.TryGetValue('A', out int noOfA);
            total += GetPrice("A", noOfA);
            checkoutContents.TryGetValue('B', out int noOfB);
            total += GetPrice("B", noOfB);
            checkoutContents.TryGetValue('C', out int noOfC);
            total += GetPrice("C", noOfC);
            checkoutContents.TryGetValue('D', out int noOfD);
            total += GetPrice("D", noOfD);
            return total;
        }
    }
}
