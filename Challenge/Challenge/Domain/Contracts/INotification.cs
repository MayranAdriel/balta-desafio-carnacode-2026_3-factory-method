namespace Challenge.Domain.Contracts
{
    public interface INotification
    {
        void Send(string recipient, string message);
    }
}
