using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public interface IRouter
    {
        void SendMessage(AbstractClient from, string message);

        void AddClient(AbstractClient client);
    }
}
