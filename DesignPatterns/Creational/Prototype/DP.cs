namespace Prototype
{
    public class Color : ICloneable
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public Color()
        {

            Thread.Sleep(2000);
            Red = 0;
            Green = 0;
            Blue = 0;
            Console.WriteLine("Renk oluşturuldu");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Show()
        {
            Console.WriteLine($"{Red} {Green} {Blue}");
        }
    }
}
