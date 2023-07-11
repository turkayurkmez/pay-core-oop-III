namespace Proxy
{
    public interface IMath
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
    }

    public class RealMath : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }

    public class ProxyMath : IMath
    {
        private RealMath realMath = new RealMath();
        public double Add(double x, double y)
        {
            //Loglama
            //Güvenli denetim
            //Benchmark ölçümleri.....
            return realMath.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return realMath.Subtract(x, y);
        }
    }
}
