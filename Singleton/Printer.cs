using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class Printer
    {
        private static Printer _instance = null;
        private Queue<string> _queue = new Queue<string>();
        private static string _instanceName;
        private static readonly object _lock = new object();

        private Printer() { }

        public static Printer GetInstance(string instanceName)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instanceName = instanceName;
                        _instance = new Printer();
                    }
                }
            }

            return _instance;
        }

        public string GetInstanceName()
        {
            return _instanceName;
        }

        public void AddDocument(string documentName)
        {
            _queue.Enqueue(documentName);
        }

        public string PrintDocument()
        {
            string documentPrinted = _queue.Dequeue();
            return documentPrinted;
        }

    }
}