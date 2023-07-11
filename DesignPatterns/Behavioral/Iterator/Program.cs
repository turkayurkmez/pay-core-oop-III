namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iterator<News> newsGallery = new Iterator<News>();
            newsGallery.Add(new News() { Title = "İyi haber", Description = "Türk Milli takımı dünya şampiyonu oldu" });
            newsGallery.Add(new News() { Title = "Daha İyi haber", Description = "Türk Fizikçi nobel ödülü kazandı" });
            newsGallery.Add(new News() { Title = "ekonomik haber", Description = "1 TL 50 Dolar oldu!!!" });
            Console.WriteLine(newsGallery.First().Description);

            Console.WriteLine(newsGallery.Current.Description);
            newsGallery.MoveNext();
            Console.WriteLine(newsGallery.Current.Description);
            newsGallery.MoveNext();

            Console.WriteLine(newsGallery.Current.Description);
            newsGallery.MovePrev();
            Console.WriteLine(newsGallery.Current.Description);

            Console.WriteLine(newsGallery.Last().Description);





        }
    }


}