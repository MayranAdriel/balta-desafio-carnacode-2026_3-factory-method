using Challenge.Domain.Contracts;

namespace Challenge.Infrasctructure.Notifications.Push
{
    public class PushNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine(message);
        }
    }
}
