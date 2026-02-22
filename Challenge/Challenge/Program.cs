using Challenge.Domain.Factories;
using Challenge.Infrasctructure.Notifications.Email;
using Challenge.Infrasctructure.Notifications.Push;
using Challenge.Infrasctructure.Notifications.Sms;
using Challenge.Infrasctructure.Notifications.Whatsapp;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações ===\n");

            NotificationSender emailSender = new EmailSender();

            // Cliente 1 prefere Email
            emailSender.Notify("Cliente 1", "Enviando por e-mail");

            NotificationSender smsSender = new SmsSender();

            // Cliente 2 prefere SMS
            smsSender.Notify("Cliente 2", "Enviando por SMS");

            NotificationSender pushSender = new PushSender();

            // Cliente 3 prefere Push
            pushSender.Notify("Cliente 3", "Enviando por push");

            NotificationSender whatsappSender = new WhatsappSender();

            // Cliente 4 prefere WhatsApp
            whatsappSender.Notify("Cliente 4", "Enviando por whatsapp"); 
        }
    }
}