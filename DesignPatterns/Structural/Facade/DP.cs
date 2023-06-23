namespace Facade
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class Product
    {
        public int Stock { get; set; }
    }
    public class Order
    {
        public decimal TotalPrice { get; set; }
    }

    public class OrderFacade
    {
        public int CreateOrder(string custName, List<OrderItem> orderItems)
        {
            Console.WriteLine($"{custName} isimli müşteri");
            Customer customer = new Customer() { Name = custName };
            orderItems.ForEach(oi => Console.WriteLine($"{oi.Name} isimli üründen {oi.Quantity} kadar alındı"));
            orderItems.ForEach(oi => Console.WriteLine($"{oi.Name} isimli ürünün stoğundan {oi.Quantity} kadar düşüldü"));

            return 1;

        }
    }
}
