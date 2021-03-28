using System;

namespace DesignPatterns.Mediator
{
    public abstract class AbstractClient
    {
        public event EventHandler<MessageReceivedEventArgs> MessageReceived = delegate { };

        public IRouter Router { get; set; }
        public string Name { get; set; }

        public abstract void Send(string toName, string message);
        public abstract void Receive(string fromName, string message);

        public void OnMessageReceived(MessageReceivedEventArgs args)
        {
            MessageReceived(this, args);
        }
    }

    public class MessageReceivedEventArgs: EventArgs
    {
        public string ReceiverName { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
    }
}