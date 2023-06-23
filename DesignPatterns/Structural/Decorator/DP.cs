namespace Decorator
{
    public abstract class Message
    {
        public abstract void Send();
    }

    public class MailMessage : Message
    {
        public override void Send()
        {
            Console.WriteLine("Mail message");
        }
    }

    public class SMSMessage : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS Message");
        }
    }

    public abstract class MessageDecorator : Message
    {
        protected Message message;

        public MessageDecorator(Message message)
        {
            this.message = message;
        }
        public override void Send()
        {
            message.Send();
        }
    }

    public class SignDecorator : MessageDecorator
    {
        private string sign;
        public SignDecorator(Message message, string sign) : base(message)
        {
            this.sign = sign;
        }

        public override void Send()
        {
            Console.WriteLine($"{sign} olarak imzalandı");
            base.Send();
        }

    }

    public class CryptoDecorator : MessageDecorator
    {
        private string algorithm;
        public CryptoDecorator(Message message, string algo) : base(message)
        {
            algorithm = algo;
        }

        public override void Send()
        {
            Console.WriteLine($"{algorithm} ile şifrelendi");
            base.Send();
        }
    }
}

