namespace DesignPatterns.Mediator
{
    public interface IRouter
    {
        void SendMessage(string senderName, string receiverName, string message);

        void AddClient(AbstractClient client);
    }
}
