using Challenge.Domain.Contracts;

namespace Challenge.Infrasctructure.Notifications.Sms
{
    public class SmsNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine(message);
        }
    }
}
