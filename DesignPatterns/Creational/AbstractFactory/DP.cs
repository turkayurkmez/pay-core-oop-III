namespace AbstractFactory
{
    public interface IKoltuk
    {
        void KoltuguGoster();
    }

    public class KlasikKoltuk : IKoltuk
    {
        public void KoltuguGoster()
        {
            Console.WriteLine("Klasik koltuk....");
        }
    }

    public class ModernKoltuk : IKoltuk
    {
        public void KoltuguGoster()
        {
            Console.WriteLine("Modern koltuk....");
        }
    }

    public class AhsapKoltuk : IKoltuk
    {
        public void KoltuguGoster()
        {
            Console.WriteLine("Ahşap koltuk....");
        }
    }
    public interface ISehpa
    {
        void SehpayiGoster();
    }

    public class KlasikSehpa : ISehpa
    {
        public void SehpayiGoster()
        {
            Console.WriteLine("Klasik sehpa ");
        }
    }

    public class ModernSehpa : ISehpa
    {
        public void SehpayiGoster()
        {
            Console.WriteLine("Modern sehpa ");

        }
    }

    public class AhsapSehpa : ISehpa
    {
        public void SehpayiGoster()
        {
            Console.WriteLine("Ahşap sehpa ");

        }
    }

    public interface IKanepe
    {
        void KanepeyiGoster();
    }


    public interface IAbstractSalonFactory
    {
        public ISehpa CreateSehpa();
        public IKoltuk CreateKoltuk();

    }

    public class ModernSalonFactory : IAbstractSalonFactory
    {
        public IKoltuk CreateKoltuk()
        {
            return new ModernKoltuk();
        }

        public ISehpa CreateSehpa()
        {
            return new ModernSehpa();
        }
    }

    public class KlasikSalonFactory : IAbstractSalonFactory
    {
        public IKoltuk CreateKoltuk()
        {
            return new KlasikKoltuk();
        }

        public ISehpa CreateSehpa()
        {
            return new KlasikSehpa();
        }
    }

    public class AhsapSalonFactory : IAbstractSalonFactory
    {
        public IKoltuk CreateKoltuk()
        {
            return new AhsapKoltuk();
        }

        public ISehpa CreateSehpa()
        {
            return new AhsapSehpa();
        }
    }

    public class SalonOlusturucu<T> where T : IAbstractSalonFactory, new()
    {
        private T factory = new T();

        public void SalonuOlustur()
        {
            var koltuk = factory.CreateKoltuk();
            var sehpa = factory.CreateSehpa();

            koltuk.KoltuguGoster();
            sehpa.SehpayiGoster();
        }

    }
}
