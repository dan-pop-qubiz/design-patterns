using System.Collections.Generic;

namespace DesignPatterns.Singleton
{
    public sealed class Printer
    {
        private static Printer _instance = null;
        private Queue<Document> _queue = new Queue<Document>();
        private static readonly object _lock = new object();
        private static int DocumentsPrinted = 0;

        private Printer() { }

        public static Printer GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Printer();
                    }
                }
            }

            return _instance;
        }

        public void AddDocument(Document document)
        {
            _queue.Enqueue(document);
        }

        public void PrintDocument()
        {
            lock (_lock)
            {
                Document documentPrinted = _queue.Dequeue();
                DocumentsPrinted++;
            }
        }

        public int GetDocumentsPrinted()
        {
            return DocumentsPrinted;
        }

        public void ResetDocumentsPrintedCount()
        {
            DocumentsPrinted = 0;
        }
    }
}