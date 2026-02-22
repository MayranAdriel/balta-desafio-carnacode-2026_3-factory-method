using Challenge.Domain.Contracts;

namespace Challenge.Infrasctructure.Notifications.Whatsapp
{
    public class WhatsappNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine(message);
        }
    }
}
