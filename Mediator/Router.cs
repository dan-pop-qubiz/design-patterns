using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public class Router: IRouter
    {
        public List<AbstractClient> clients = new List<AbstractClient>();

        public void AddClient(AbstractClient client)
        {
            clients.Add(client);
        }

        public void SendMessage(string senderName, string receiverName, string message)
        {
            AbstractClient receiver = GetClientByName(receiverName);

            if (receiver != null)
            {
                receiver.Receive(senderName, message);
            }
        }

        private AbstractClient GetClientByName(string name)
        {
            return clients.Find(item => item.Name == name);
        }
    }
}
