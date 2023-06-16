namespace FactoryMethod
{
    public class Geometry
    {
        public int Unit1 { get; set; }
        public int Unit2 { get; set; }

        public Geometry()
        {

        }

    }

    public class Triangle : Geometry
    {

    }

    public class Square : Geometry
    {

    }

    public class Circle : Geometry
    {

    }

    public static class GeometyCreator
    {
        public static Geometry Create(string form)
        {
            switch (form)
            {
                case "Triangle":
                    return new Triangle();
                default:
                    return new Square();

            }
        }
    }
}
