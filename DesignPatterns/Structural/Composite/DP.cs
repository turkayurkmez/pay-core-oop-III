namespace Composite
{

    public interface INode
    {

    }
    public class Composite<T> where T : class, INode
    {
        public T Node { get; set; }
        public List<Composite<T>> Children { get; set; } = new List<Composite<T>>();

        public Composite<T> Add(T child)
        {
            Composite<T> newComposite = new Composite<T>() { Node = child };
            Children.Add(newComposite);
            return newComposite;
        }

        public static void Show(int level, Composite<T> composite)
        {
            string line = new string('-', level);
            Console.WriteLine($"{line} {composite.Node}");
            foreach (var item in composite.Children)
            {
                Show(level + 1, item);
            }
        }
    }

    public class Category : INode
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
