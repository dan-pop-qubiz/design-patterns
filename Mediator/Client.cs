using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public class Client : AbstractClient
    {
        public override void Receive(string message)
        {
            MessageReceivedEventArgs args = new MessageReceivedEventArgs { Message = message, Receiver = this };
            OnMessageReceived(args);
            
        }

        public override void Send(string message)
        {
            Router.SendMessage(this, message);
        }
    }
}
