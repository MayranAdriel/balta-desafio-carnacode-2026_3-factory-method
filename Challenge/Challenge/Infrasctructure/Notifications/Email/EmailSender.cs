using Challenge.Domain.Contracts;
using Challenge.Domain.Factories;

namespace Challenge.Infrasctructure.Notifications.Email
{
    public class EmailSender : NotificationSender
    {
        public override INotification CreateNotification() => new EmailNotification();
    }
}
