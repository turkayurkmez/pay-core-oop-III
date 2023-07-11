namespace Strategy
{

    public interface ISortAlgorithm
    {
        void Sort();

    }
    public class ProductCollection
    {
        public void Sort(ISortAlgorithm sortAlgorithm)
        {
            //BubbleSort....
            sortAlgorithm.Sort();
        }
    }

    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public void Sort()
        {
            Console.WriteLine("Bubble");
        }
    }

    public class HeapAlgorithm : ISortAlgorithm
    {
        public void Sort()
        {
            Console.WriteLine("Heap");
        }
    }
}
