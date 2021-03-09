using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public abstract class AbstractClient
    {
        public event EventHandler<MessageReceivedEventArgs> MessageReceived = delegate { };

        public IRouter Router { get; set; }
        public string Name { get; set; }

        public abstract void Send(string message);
        public abstract void Receive(string message);

        public void OnMessageReceived(MessageReceivedEventArgs args)
        {
            MessageReceived(this, args);
        }

    }

    public class MessageReceivedEventArgs: EventArgs
    {
        public AbstractClient Receiver { get; set; }
        public string Message { get; set; }
    }
}
