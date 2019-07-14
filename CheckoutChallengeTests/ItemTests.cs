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
    public class ItemTests
    {
        [TestMethod()]
        public void GetPricePerItemTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ItemTest()
        {
            Item item = new Item('A', 2.5);
            Assert.IsInstanceOfType(item.Name, typeof(char));
            Assert.IsInstanceOfType(item.Price, typeof(double));
        }
    }
}