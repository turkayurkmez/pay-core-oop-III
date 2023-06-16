// See https://aka.ms/new-console-template for more information

changeBackgroundColor(ConsoleColor.Red);

Console.Write("Ürün adını giriniz: >");
string productName = Console.ReadLine();
Console.Write("Ürün fiyatı: >");
decimal price = decimal.Parse(Console.ReadLine());

Console.WriteLine("Ürün kaydedildi");

//Her sınıf; sadece bir sorumluluğa sahip olmalıdır!
//Bir sınıfta değişiklik (yeni metot eklemek, ya da metot içinde değişiklik yapmak) için birden fazla motivasyonunuz varsa, prensibi ihlal ediyorsunuz demektir.




void changeBackgroundColor(ConsoleColor color)
{
    Console.BackgroundColor = color;
    Console.ForegroundColor = ConsoleColor.White;
}