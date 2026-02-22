using Challenge.Domain.Contracts;
using Challenge.Domain.Factories;

namespace Challenge.Infrasctructure.Notifications.Push
{
    public class PushSender : NotificationSender
    {
        public override INotification CreateNotification() => new PushNotification();   
    }
}
