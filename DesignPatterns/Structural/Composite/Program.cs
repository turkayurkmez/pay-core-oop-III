// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, World!");

Category electonic = new Category { Name = "Elektronik" };
Composite<Category> composite = new Composite<Category>();
var root = composite.Add(electonic);
var node1 = root.Add(new Category { Name = "Computer" });
var node2 = node1.Add(new Category { Name = "Laptops" });
var node3 = root.Add(new Category { Name = "Home Theatre System" });
var node4 = node3.Add(new Category { Name = "5+1" });

Composite<Category>.Show(0, root);

