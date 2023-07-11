namespace Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class CommandInvoker
    {
        private Queue<ICommand> commands = new Queue<ICommand>();
        public void AddCommand(ICommand command) => commands.Enqueue(command);

        public void ExecuteCommands()
        {
            while (commands.Count > 0)
            {
                var command = commands.Dequeue();
                command.Execute();
            }
        }

        public void Clear() => commands.Clear();
        public void RemoveFirstCommand() => commands.Dequeue();
    }

    public class UpdateProductPriceCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Ürün fiyatı güncellendi");
        }
    }

    public class CustomerEmailChangeCommand : ICommand
    {
        public string Customer { get; set; }
        public string NewEmail { get; set; }
        public void Execute()
        {
            Console.WriteLine($"{Customer} müşterisinin e-posta adresi {NewEmail} olarak değiştirildi");
        }
    }
}
