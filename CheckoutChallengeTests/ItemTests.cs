using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutChallenge.Tests
{
    [TestClass()]
    public class ItemTests
    {

        [TestMethod()]
        public void ItemTestWithoutSpecialPrice()
        {
            Item item = new Item('A', 2.5);
            Assert.IsInstanceOfType(item.Name, typeof(char));
            Assert.IsInstanceOfType(item.Price, typeof(double));
        }

        [TestMethod()]
        public void ItemTestWithSpecialPrice()
        {
            Item item = new Item('A', 2.5, new PriceForNumberOfItems(3, 12.5));
            Assert.IsInstanceOfType(item.Name, typeof(char));
            Assert.IsInstanceOfType(item.Price, typeof(double));
            Assert.IsInstanceOfType(item.SpecialPrice.NoOfItems, typeof(int));
            Assert.IsInstanceOfType(item.SpecialPrice.GroupPrice, typeof(double));
        }
    }
}