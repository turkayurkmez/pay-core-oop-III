namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Problem; 
             * 
             * Bir uygulama; kullanıcıdan gelen komutları bir arada tutup, denetleme sürecini yönetmek istiyorsunuz. Bu problemi nasıl çözersiniz?
             * 
             */

            CommandInvoker commandInvoker = new CommandInvoker();
            commandInvoker.AddCommand(new UpdateProductPriceCommand());
            commandInvoker.AddCommand(new CustomerEmailChangeCommand() { Customer = "Türkay", NewEmail = "turkay.urkmez@gmail.com" });

            commandInvoker.ExecuteCommands();
        }
    }
}