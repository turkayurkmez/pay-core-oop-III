// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

decimal value = -5;
Product product = new Product();
//if (value>0)
//{
//    product.Price = value;
//}
//else
//{
//    Console.WriteLine("0'dan küçük olamaz");
//}
product.SetPrice(value);
product.Name = "Test";
product.Stock = 1000;

Product product1 = new Product { Category = "Test" };
//product1.Category = "Test2";