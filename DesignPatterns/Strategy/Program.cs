namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCollection productCollection = new ProductCollection();
            BubbleSortAlgorithm bubbleSortAlgorithm = new BubbleSortAlgorithm();
            HeapAlgorithm heapAlgorithm = new HeapAlgorithm();
            productCollection.Sort(bubbleSortAlgorithm);
            productCollection.Sort(heapAlgorithm);
        }
    }
}