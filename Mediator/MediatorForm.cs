using System;
using System.Windows.Forms;

namespace DesignPatterns.Mediator
{
    public partial class MediatorForm : Form
    {
        public IRouter router;
        public AbstractClient clientAna;
        public AbstractClient clientAndrei;
        public AbstractClient clientAnca;
        public AbstractClient clientAlin;

        public MediatorForm()
        {
            InitializeComponent();
        }

        private void MediatorForm_Load(object sender, EventArgs e)
        {
            router = new Router();

            clientAna = CreateClient("Ana", new string[3] { "Andrei", "Anca", "Alin" });
            clientAndrei = CreateClient("Andrei", new string[3] { "Ana", "Anca", "Alin" });
            clientAnca = CreateClient("Anca", new string[3] { "Ana", "Andrei", "Alin" });
            clientAlin = CreateClient("Alin", new string[3] { "Ana", "Andrei", "Anca" });
        }

        private void ClientReceivedMessage(object sender, MessageReceivedEventArgs e)
        {
            string line = e.SenderName + ": " + e.Message + Environment.NewLine;

            switch (e.ReceiverName)
            {
                case "Ana":
                    textBoxReceiveAna.AppendText(line);
                    break;
                case "Andrei":
                    textBoxReceiveAndrei.AppendText(line);
                    break;
                case "Anca":
                    textBoxReceiveAnca.AppendText(line);
                    break;
                case "Alin":
                    textBoxReceiveAlin.AppendText(line);
                    break;
            }
        }

        private void buttonSendAna_Click(object sender, EventArgs e)
        {
            if (comboBoxAnaSendTo.SelectedIndex > -1 && textBoxSendAna.TextLength > 0)
            {
                clientAna.Send(comboBoxAnaSendTo.Text, textBoxSendAna.Text);
                textBoxSendAna.Clear();
                comboBoxAnaSendTo.SelectedIndex = -1;
                comboBoxAnaSendTo.SelectedText = "Send to";
            }
        }

        private void buttonSendAndrei_Click(object sender, EventArgs e)
        {
            if (comboBoxAndreiSendTo.SelectedIndex > -1 && textBoxSendAndrei.TextLength > 0)
            {
                clientAndrei.Send(comboBoxAndreiSendTo.Text, textBoxSendAndrei.Text);
                textBoxSendAndrei.Clear();
                comboBoxAndreiSendTo.SelectedIndex = -1;
                comboBoxAndreiSendTo.SelectedText = "Send to";
            }
        }

        private void buttonSendAnca_Click(object sender, EventArgs e)
        {
            if (comboBoxAncaSendTo.SelectedIndex > -1 && textBoxSendAnca.TextLength > 0)
            {
                clientAnca.Send(comboBoxAncaSendTo.Text, textBoxSendAnca.Text);
                textBoxSendAnca.Clear();
                comboBoxAncaSendTo.SelectedIndex = -1;
                comboBoxAncaSendTo.SelectedText = "Send to";
            }
        }
        private void buttonSendAlin_Click(object sender, EventArgs e)
        {
            if (comboBoxAlinSendTo.SelectedIndex > -1 && textBoxSendAlin.TextLength > 0)
            {
                clientAlin.Send(comboBoxAlinSendTo.Text, textBoxSendAlin.Text);
                textBoxSendAndrei.Clear();
                comboBoxAlinSendTo.SelectedIndex = -1;
                comboBoxAlinSendTo.SelectedText = "Send to";
            }
        }

        private AbstractClient CreateClient(string name, string[] friendsList)
        {
            AbstractClient client = new Client
            {
                Name = name,
                Router = router
            };

            client.MessageReceived += ClientReceivedMessage;
            router.AddClient(client);

            switch (name)
            {
                case "Ana":
                    comboBoxAnaSendTo.Items.AddRange(friendsList);
                    break;
                case "Andrei":
                    comboBoxAndreiSendTo.Items.AddRange(friendsList);
                    break;
                case "Anca":
                    comboBoxAncaSendTo.Items.AddRange(friendsList);
                    break;
                case "Alin":
                    comboBoxAlinSendTo.Items.AddRange(friendsList);
                    break;
            }

            return client;
        }

    }
}