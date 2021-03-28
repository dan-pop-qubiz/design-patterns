using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Runner
    {
        public event EventHandler<MessageReceivedEventArgs> MessageReceived = delegate { };

        public Printer Printer1 { get; set; }
        public Printer Printer2 { get; set; }
        public Printer Printer3 { get; set; }
        public Printer Printer4 { get; set; }

        public Printer Printer5 { get; set; }


        public List<User> Users { get; set; }

        private Random _random = new Random();

        private MessageReceivedEventArgs _args;

        public void Run(int numberOfUsers, int maxNumberOfDocuments)
        {
            Users = new List<User> { };

            for (int i = 0; i < numberOfUsers; i++)
            {
                Users.Add(CreateUser(i, maxNumberOfDocuments));
            }

            Printer1 = Printer.GetInstance();
            Printer2 = Printer.GetInstance();
            Printer3 = Printer.GetInstance();
            Printer4 = Printer.GetInstance();
            Printer5 = Printer.GetInstance();

            if (Printer1 == Printer2 && Printer2 == Printer3 && Printer3 == Printer4 && Printer4 == Printer5)
            {
                _args = new MessageReceivedEventArgs { Message = "Printers are same instance" };
            }
            else
            {
                _args = new MessageReceivedEventArgs { Message = "Printers are NOT the same instance" };
            }
            MessageReceived(this, _args);

            Printer1.ResetDocumentsPrintedCount();

            int documentsAdded = 0;
            foreach(User user in Users)
            {
                _args = new MessageReceivedEventArgs { Message = user.Name + " has " + user.Documents.Count + " documents" };
                MessageReceived(this, _args);

                foreach (Document document in user.Documents)
                {
                    _args = new MessageReceivedEventArgs { Message = user.Name + " created document " + document.Name };
                    MessageReceived(this, _args);

                    Printer1.AddDocument(document);
                    documentsAdded++;
                }
            }
            _args = new MessageReceivedEventArgs { Message = " Documents added to printer: " + documentsAdded };
            MessageReceived(this, _args);

            Parallel.ForEach(Users, user => {

                Parallel.ForEach(user.Documents, document =>
                {
                    Printer1.PrintDocument();
                });

            });

            _args = new MessageReceivedEventArgs { Message = " Documents printed: " + Printer1.GetDocumentsPrinted() };
            MessageReceived(this, _args);
        }

        private User CreateUser(int index, int maxNumberOfDocuments)
        {
            User user = new User { Name = "User_" + index, Documents = new List<Document> { } };

            int numberOfDocuments = _random.Next(1, maxNumberOfDocuments);

            for (int i = 0; i < numberOfDocuments; i++)
            {
                user.Documents.Add(CreateDocument(i));
            }

            return user;
        }

        private Document CreateDocument(int index)
        {
            return new Document { Name = "Document_" + index };
        }

    }

    public class MessageReceivedEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
