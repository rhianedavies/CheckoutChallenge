using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 4);
            Assert.AreEqual(1.8, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA2()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 2);
            Assert.AreEqual(1.0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA9()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 9);
            Assert.AreEqual(3.9, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA11()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 11);
            Assert.AreEqual(4.9, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestA0()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("A", 0);
            Assert.AreEqual(0, price, 0.001);
        }



        [TestMethod()]
        public void GetPriceTestB0()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 0);
            Assert.AreEqual(0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB1()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 1);
            Assert.AreEqual(0.3, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB2()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 2);
            Assert.AreEqual(0.45, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB3()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 3);
            Assert.AreEqual(0.75, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestB4()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("B", 4);
            Assert.AreEqual(0.9, price, 0.001);
        }





        [TestMethod()]
        public void GetPriceTestC0()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("C", 0);
            Assert.AreEqual(0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestC1()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("C", 1);
            Assert.AreEqual(0.7, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestC3()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("C", 3);
            Assert.AreEqual(2.1, price, 0.001);
        }





        [TestMethod()]
        public void GetPriceTestD0()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("D", 0);
            Assert.AreEqual(0, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestD1()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("D", 1);
            Assert.AreEqual(0.2, price, 0.001);
        }

        [TestMethod()]
        public void GetPriceTestD3()
        {
            MakeStock();
            Checkout checkout = new Checkout();
            double price = checkout.GetPrice("D", 3);
            Assert.AreEqual(0.6, price, 0.001);
        }



        [TestMethod()]
        public void GetTotalTest()
        {
            Assert.Fail();
        }
    }
}