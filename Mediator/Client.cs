namespace DesignPatterns.Mediator
{
    public class Client : AbstractClient
    {
        public override void Receive(string fromName, string message)
        {
            MessageReceivedEventArgs args = new MessageReceivedEventArgs { SenderName = fromName, ReceiverName = Name, Message = message };
            OnMessageReceived(args);
        }

        public override void Send(string toName, string message)
        {
            Router.SendMessage(Name, toName, message);
        }
    }
}