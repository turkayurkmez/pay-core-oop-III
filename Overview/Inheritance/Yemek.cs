namespace Inheritance
{
    public class Yemek
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public int PismeSuresi { get; set; }

        public List<string> Malzemeler { get; set; }
        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} isimli yemek, {PismeSuresi} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine("Yanında pilav ile ikram edildi");
        }
    }

    public class Corba : Yemek
    {
        public bool LimonVarMi { get; set; }
    }

    public class Kurufasulye : Yemek
    {

    }

    public class Salata : Yemek
    {
        public List<string> EkstaSoslar { get; set; }
    }

    public class Kofte : Yemek
    {
        public string KofteTuru { get; set; }
    }

    public class Baklava : Yemek
    {
        public bool FistikliMi { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine("Yanında dondurma ile ikram edildi");
        }

    }


}
