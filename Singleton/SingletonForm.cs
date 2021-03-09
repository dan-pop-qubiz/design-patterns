using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Singleton
{
    public partial class SingletonForm : Form
    {
        private delegate void SafeCallDelegate(string text);

        public SingletonForm()
        {
            InitializeComponent();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            int numberOfDocuments = int.Parse(numberOfDocumentsTextbox.Text);
            Printer[] printers = new Printer[numberOfDocuments];

            singletonFlowResult.Clear();

            for (int i = 0; i < numberOfDocuments; i++)
            {
                Thread thread = new Thread(new ThreadStart(() => { printers[i] = GetPrinterInstance("instance " + i.ToString(), "document " + i.ToString()); }));
                thread.Start();
                Thread.Sleep(100);
            }

            MessageBox.Show("All threads completed");
        }

        private Printer GetPrinterInstance(string instanceName, string documentName)
        {
            Printer printer = Printer.GetInstance(instanceName);

            string instanceCreatedName = printer.GetInstanceName();
            WriteResult("Instance name:" + instanceCreatedName);

            printer.AddDocument(documentName);
            WriteResult("Added document:" + documentName);

            string printedDocumentName = printer.PrintDocument();
            WriteResult("Printed document:" + printedDocumentName);

            return printer;
        }

        private void WriteResult(string text)
        {
            string line = text + Environment.NewLine;
            if (singletonFlowResult.InvokeRequired)
            {
                var safeDelegate = new SafeCallDelegate(WriteResult);
                singletonFlowResult.Invoke(safeDelegate, new object[] { line });
            }
            else
            {
                singletonFlowResult.AppendText(line);
            }
        }

    }
}
