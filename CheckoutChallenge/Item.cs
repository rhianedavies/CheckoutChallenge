namespace CheckoutChallenge
{
    public class Item
    {
        public char Name { get; set; }

        public double Price { get; set; }

        public PriceForNumberOfItems SpecialPrice { get; set; }

        public Item(char name, double price)
        {
            Name = name;
            Price = price;
        }

        public Item(char name, double price, PriceForNumberOfItems specialPrice)
        {
            Name = name;
            Price = price;
            SpecialPrice = new PriceForNumberOfItems(specialPrice.NoOfItems, specialPrice.GroupPrice);;
        }

        

    }
}
