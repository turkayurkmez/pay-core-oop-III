namespace DependencyInversion
{
    public class Report
    {
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender;
        }
        //public MailSender MailSender { get; set; }
        public void SendReport()
        {
            //MailSender mailSender = new MailSender();
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send() => Console.WriteLine("Mail gönderildi");
    }

    public class WhatsappSender : ISender
    {
        public void Send() => Console.WriteLine("Whatsapp gönderildi");
    }

    public class TelegramSender : ISender
    {
        public void Send() => Console.WriteLine("Telegram gönderildi");
    }
}
