namespace Constructors
{
    public class Order
    {
        public decimal TotalPrice { get; set; }
        public string Customer { get; set; }
        public decimal TaxPrice { get; set; }

        public Order() : this("NoName")
        {

        }
        public Order(string customer)
        {
            TaxPrice = 0.18M;
            Customer = customer;
        }
        //public Order(decimal taxPrice)
        //{
        //    TaxPrice = taxPrice;
        //}



    }
}
