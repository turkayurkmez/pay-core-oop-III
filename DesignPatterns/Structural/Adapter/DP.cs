namespace Adapter
{
    public class Product
    {
        public string Name { get; set; }
    }

    public interface IRequest
    {
        Product GetProduct();
    }
    //Adapte edilecek
    public class XMLSource
    {
        public Product GetProductFromXml()
        {

            Console.WriteLine("XML üzerinden veri çekiliyor!");
            return new Product { Name = "Bu ürün XML'den dönüştü" };
        }
    }

    public class Adapter : IRequest
    {
        private readonly XMLSource source;

        public Adapter(XMLSource source)
        {
            this.source = source;
        }

        public Product GetProduct()
        {
            return source.GetProductFromXml();
        }
    }

}
