using Challenge.Domain.Contracts;
using Challenge.Domain.Factories;

namespace Challenge.Infrasctructure.Notifications.Whatsapp
{
    public class WhatsappSender : NotificationSender
    {
        public override INotification CreateNotification() => new WhatsappNotification();
    }
}
