using Challenge.Domain.Contracts;

namespace Challenge.Infrasctructure.Notifications.Email
{
    public class EmailNotification : INotification
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine(message);
        }
    }
}
