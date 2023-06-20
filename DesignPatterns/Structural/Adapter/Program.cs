// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");
/*
 *  Uyumsuz arabirimlere sahip nesnelerin işbirliği yapmasına ihtiyacınız varsa; bu deseni kullanmalısınız.
 *  
 *  
 */

XMLSource source = new XMLSource();
IRequest request = new Adapter.Adapter(source);
//istemci ile XML source uyumlu değildi. 
Console.WriteLine(request.GetProduct().Name);