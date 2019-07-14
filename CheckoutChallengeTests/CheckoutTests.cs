using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CheckoutChallenge.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void AddItemToCheckoutTest()
        {
            Checkout checkout = new Checkout();
            checkout.AddItemToCheckout(new Item('A', 2.6));
            Assert.IsNotNull(checkout);
        }

        [TestInitialize]
        public void MakeStock()
        {
            Stock.AvailableItems = new List<Item>
            {
                new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)),
                new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)),
                new Item('C', 0.7),
                new Item('D', 0.2)
            };
        }

        [TestMethod()]
        public void GetPriceTestA4()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 4);
            Assert.AreEqual(1.8, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA2()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 2);
            Assert.AreEqual(1.0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA9()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 9);
            Assert.AreEqual(3.9, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA11()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 11);
            Assert.AreEqual(4.9, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA0()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 0);
            Assert.AreEqual(0, price, 0.001);
        }



        [TestMethod()]
        public void GetPriceTestB0()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 0);
            Assert.AreEqual(0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB1()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 1);
            Assert.AreEqual(0.3, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB2()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 2);
            Assert.AreEqual(0.45, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB3()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 3);
            Assert.AreEqual(0.75, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB4()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 4);
            Assert.AreEqual(0.9, price, 0.001);
        }





        [TestMethod()]
        public void GetPriceTestC0()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("C", 0);
            Assert.AreEqual(0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestC1()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("C", 1);
            Assert.AreEqual(0.7, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestC3()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("C", 3);
            Assert.AreEqual(2.1, price, 0.001);
        }





        [TestMethod()]
        public void GetPriceTestD0()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("D", 0);
            Assert.AreEqual(0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestD1()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("D", 1);
            Assert.AreEqual(0.2, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestD3()
        {
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("D", 3);
            Assert.AreEqual(0.6, price, 0.001);
        }



        [TestMethod()]
        public void GetTotalTest1A()
        {
            Checkout checkout = new Checkout();
            checkout.AddItemToCheckout(new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)));
            var total = checkout.GetTotal();
            Assert.AreEqual(0.5, total, 0.001);
        }

        [TestMethod()]
        public void GetTotalTest1A1B()
        {
            Checkout checkout = new Checkout();
            checkout.AddItemToCheckout(new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)));
            checkout.AddItemToCheckout(new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)));
            var total = checkout.GetTotal();
            Assert.AreEqual(0.8, total, 0.001);
        }

        [TestMethod()]
        public void GetTotalTest1A1B1C()
        {
            Checkout checkout = new Checkout();
            checkout.AddItemToCheckout(new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)));
            checkout.AddItemToCheckout(new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)));
            checkout.AddItemToCheckout(new Item('C', 0.7));
            var total = checkout.GetTotal();
            Assert.AreEqual(1.5, total, 0.001);
        }

        [TestMethod()]
        public void GetTotalTest1A1B1C1D()
        {
            Checkout checkout = new Checkout();
            checkout.AddItemToCheckout(new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)));
            checkout.AddItemToCheckout(new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)));
            checkout.AddItemToCheckout(new Item('C', 0.7));
            checkout.AddItemToCheckout(new Item('D', 0.2));
            var total = checkout.GetTotal();
            Assert.AreEqual(1.7, total, 0.001);
        }

        [TestMethod()]
        public void GetTotalTest2A3B4C5D()
        {
            Checkout checkout = new Checkout();
            checkout.AddItemToCheckout(new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)));
            checkout.AddItemToCheckout(new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)));
            checkout.AddItemToCheckout(new Item('C', 0.7));
            checkout.AddItemToCheckout(new Item('D', 0.2));
            checkout.AddItemToCheckout(new Item('A', 0.5, new PriceForNumberOfItems(3, 1.3)));
            checkout.AddItemToCheckout(new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)));
            checkout.AddItemToCheckout(new Item('C', 0.7));
            checkout.AddItemToCheckout(new Item('D', 0.2));
            checkout.AddItemToCheckout(new Item('B', 0.3, new PriceForNumberOfItems(2, 0.45)));
            checkout.AddItemToCheckout(new Item('C', 0.7));
            checkout.AddItemToCheckout(new Item('D', 0.2));
            checkout.AddItemToCheckout(new Item('C', 0.7));
            checkout.AddItemToCheckout(new Item('D', 0.2));
            checkout.AddItemToCheckout(new Item('D', 0.2));
            var total = checkout.GetTotal();
            Assert.AreEqual(5.55, total, 0.001);
        }


    }
}