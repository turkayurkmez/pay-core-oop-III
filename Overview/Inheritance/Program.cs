// See https://aka.ms/new-console-template for more information
using Inheritance;

//Inheritance ve Polymorphism aynı projede anlatıldı;

Console.WriteLine("Hello, World!");

Corba corba = new Corba();
Kofte kofte = new Kofte();
Salata salata = new Salata();
Baklava baklava = new Baklava();

Asci asci = new Asci();
asci.Pisir(kofte);
asci.Pisir(corba);
asci.Pisir(baklava);