namespace FactoryMethod
{

    //Fabrikanın üreteceği nesnelerin interface'ini belirle:
    public interface ICommandExecuter
    {
        void Execute();
    }

    public class SQLCommandExecuter : ICommandExecuter
    {
        public void Execute()
        {
            Console.WriteLine("Bir sql komutu çalıştı");
        }
    }

    public class OracleCommandExecuter : ICommandExecuter
    {
        public void Execute()
        {
            Console.WriteLine("Bir oracle komutu çalıştı");

        }
    }

    public class PostgreSqlCommandExecuter : ICommandExecuter
    {
        public void Execute()
        {
            Console.WriteLine("Bir postgre komutu çalıştı");

        }
    }

    public abstract class Helper
    {

        protected ICommandExecuter commandExecuter;
        public Helper()
        {
            createCommandExecuter();
        }
        //Factory Method:
        protected abstract void createCommandExecuter();
        public void ExecuteCommand()
        {
            commandExecuter.Execute();
        }
    }

    public class SqlHelper : Helper
    {
        protected override void createCommandExecuter()
        {
            commandExecuter = new SQLCommandExecuter();
        }
    }

    public class OracleHelper : Helper
    {
        protected override void createCommandExecuter()
        {
            commandExecuter = new OracleCommandExecuter();
        }
    }

    public class PostgreHelper : Helper
    {
        protected override void createCommandExecuter()
        {
            commandExecuter = new PostgreSqlCommandExecuter();

        }
    }
}
