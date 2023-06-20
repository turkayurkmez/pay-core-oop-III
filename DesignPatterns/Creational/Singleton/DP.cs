namespace Singleton
{
    public interface IDBOperator
    {
        public void Execute();
    }

    public class SqlDbOperator : IDBOperator
    {

        private SqlDbOperator()
        {

        }
        private static SqlDbOperator instance;
        public static SqlDbOperator CreateInstance()
        {
            if (instance == null)
            {
                instance = new SqlDbOperator();
            }
            return instance;
        }

        public string State { get; set; }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
