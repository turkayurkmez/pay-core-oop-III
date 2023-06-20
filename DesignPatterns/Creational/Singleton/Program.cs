// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
var sqlInst1 = SqlDbOperator.CreateInstance();
sqlInst1.State = "SQL'e Bağlandı";
var inst2 = SqlDbOperator.CreateInstance();
Console.WriteLine(inst2.State);

