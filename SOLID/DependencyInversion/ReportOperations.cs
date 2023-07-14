namespace DependencyInversion
{

    public class ReportOperations
    {
        private ISender Sender;
        public ReportOperations(ISender sender)
        {
            Sender = sender;
        }
        public void Send()
        {

            Sender.Send();
        }
    }
    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }
    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }


    public class DiscordSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Discord ile gönderildi");
        }
    }
}
