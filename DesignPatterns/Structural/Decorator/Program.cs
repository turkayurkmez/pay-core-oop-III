// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");
//FileStream stream = getStream();
//GZipStream gZipStream = new GZipStream(stream, CompressionLevel.SmallestSize);
//CryptoStream cryptoStream = new CryptoStream(gZipStream, null, CryptoStreamMode.Write);

//Problem: Hali hazırda zaten bellekte olan bir nesneye nasıl yeni özellik veya operasyon ekleriz?

SMSMessage message = new SMSMessage();
SignDecorator signDecorator = new SignDecorator(message, "Türkay Ürkmez");
CryptoDecorator cryptoDecorator = new CryptoDecorator(signDecorator, "SHA256");
cryptoDecorator.Send();


FileStream getStream()
{
    return null;
}