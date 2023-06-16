// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/* Bir sistem gelişime AÇIK, değişime KAPALI olmalıdır */
//Gelişim kuralı: ya miras alacaksınız, ya da implemente edeceksiniz.

OrderManagement orderManagement = new OrderManagement();
Customer customer = new Customer() { Card = new Gold(), Name = "Türkay Ürkmez" };
orderManagement.Customer = customer;
var price = orderManagement.GetDiscountedPrice(1000);
Console.WriteLine(price);