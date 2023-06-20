// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");
Color black = new Color();
black.Show();
Color red = (Color)black.Clone();
red.Red = 255;
red.Show();
Color green = (Color)black.Clone();
green.Green = 255;
green.Show();
Color blue = (Color)black.Clone();
blue.Blue = 255;
blue.Show();


string[] cities = { "A", "B", "C" };
cities.ToList().ForEach(c => Console.WriteLine(c));
List<string> cloneOfCities = ((string[])cities.Clone()).ToList();
cloneOfCities[0] = "F";
cloneOfCities.ForEach(c => Console.WriteLine(c));

/*
 * Problem:
 *    Instance'i alınırken constructor'da çok zaman haracayan bir nesne düşünün. Bu sınıftan bir çok nesneye ihtiyacınız olsun. Bu nesneleri minimum zamana nasıl indirgersiniz?
 */