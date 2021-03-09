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

        public void SendMessage(AbstractClient from, string message)
        {
            foreach(AbstractClient client in clients)
            {
                if (client.Name != from.Name)
                {
                    string receivedMessage = from.Name + ": " + message;
                    client.Receive(receivedMessage);
                }
            }
        }
    }
}
