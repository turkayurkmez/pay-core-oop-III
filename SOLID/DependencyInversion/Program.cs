// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
//Bağımlılığı tersine çevir.
//...... olmadan ...... çalışmaz
// ram   olmadan bilgisayar
// uç    olmadan matkap çalışmaz
//uç     olmadan 0.7 kalem çalışmaz

Report report = new Report(new WhatsappSender());