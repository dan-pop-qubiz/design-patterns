using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Mediator
{
    public partial class MediatorForm : Form
    {
        public IRouter router;
        public AbstractClient clientAna;
        public AbstractClient clientAndrei;

        public MediatorForm()
        {
            InitializeComponent();
        }

        private void MediatorForm_Load(object sender, EventArgs e)
        {
            router = new Router();
            clientAna = new Client
            {
                Name = "Ana",
                Router = router
            };
            clientAna.MessageReceived += ClientReceivedMessage;

            clientAndrei = new Client
            {
                Name = "Andrei",
                Router = router
            };
            clientAndrei.MessageReceived += ClientReceivedMessage;

            router.AddClient(clientAna);
            router.AddClient(clientAndrei);
        }

        private void ClientReceivedMessage(object sender, MessageReceivedEventArgs e)
        {
            string receiverName = e.Receiver.Name;
            string line = e.Message + Environment.NewLine;

            switch (receiverName)
            {
                case "Ana":
                    textBoxReceiveAna.AppendText(line);
                    break;
                case "Andrei":
                    textBoxReceiveAndrei.AppendText(line);
                    break;
            }
        }

        private void buttonSendAna_Click(object sender, EventArgs e)
        {
            string text = textBoxSendAna.Text;

            clientAna.Send(text);

            textBoxSendAna.Clear();
        }

        private void buttonSendAndrei_Click(object sender, EventArgs e)
        {
            string text = textBoxSendAndrei.Text;

            clientAndrei.Send(text);

            textBoxSendAndrei.Clear();
        }
    }
}
