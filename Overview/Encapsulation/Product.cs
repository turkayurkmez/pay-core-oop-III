namespace Encapsulation
{
    public class Product
    {
        private decimal price;
        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("fiyat negatif olamaz");
            }

            this.price = value;
        }

        public decimal GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Stock { get; set; }

        public void ChangeStock(int value)
        {
            Stock = value;
            IsAvailable = Stock > 0;
        }
        public bool IsAvailable { get; private set; }

        public string Category { get; init; }




    }
}
