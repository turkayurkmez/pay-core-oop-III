// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

OrderFacade orderFacade = new OrderFacade();
var items = new List<OrderItem> { new() { Name = "A", Quantity = 3 }, new() { Name = "B", Quantity = 5 } };
orderFacade.CreateOrder("Türkay", items);

