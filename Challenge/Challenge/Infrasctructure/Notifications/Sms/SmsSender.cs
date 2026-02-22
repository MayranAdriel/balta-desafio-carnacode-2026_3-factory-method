using Challenge.Domain.Contracts;
using Challenge.Domain.Factories;

namespace Challenge.Infrasctructure.Notifications.Sms
{
    public class SmsSender : NotificationSender
    {
        public override INotification CreateNotification() => new SmsNotification();
    }
}
