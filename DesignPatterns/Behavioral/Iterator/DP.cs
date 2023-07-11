using System.Collections;

namespace Iterator
{

    public class News
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class Iterator<T> : IEnumerator<T>
    {

        private List<T> collection = new List<T>();
        private int position = 0;
        public T Current => collection[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            position = 0;

        }

        public void Add(T item)
        {
            collection.Add(item);
            position = collection.Count - 1;
        }

        public bool MoveNext()
        {
            if (position < collection.Count - 1)
            {
                position++;

            }
            return position < collection.Count - 1;
        }

        public bool MovePrev()
        {
            if (position > 0)
            {
                position--;
            }
            return position > 0;
        }

        public void Reset()
        {
            position = 0;
        }

        public T First()
        {
            position = 0;
            return collection[position];
        }
        public T Last()
        {
            position = collection.Count - 1;
            return collection[position];
        }

    }
}
