namespace Aula13.Bad
{
    public interface IEmailService
    {
        void Send();
    }

    public class EmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("Sending e-mail.");
        }
    }

    public class FakeEmailService : IEmailService
    {
        public void Send()
        {
            Console.WriteLine("FAKE.");
        }
    }

    public class UserService(IEmailService emailService)
    {

    }
}
