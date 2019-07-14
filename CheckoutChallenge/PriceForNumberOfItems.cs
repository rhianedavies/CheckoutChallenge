namespace CheckoutChallenge
{
    public class PriceForNumberOfItems
    {
        public int NoOfItems { get; set; }

        public double GroupPrice { get; set; }

        public PriceForNumberOfItems(int noOfItems, double groupPrice)
        {
            NoOfItems = noOfItems;
            GroupPrice = groupPrice;
        }
    }

    
}