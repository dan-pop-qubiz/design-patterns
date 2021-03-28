using System;
using System.Windows.Forms;

namespace DesignPatterns.Singleton
{
    public partial class SingletonForm : Form
    {
        public Runner runner;

        private delegate void SafeCallDelegate(string text);

        public SingletonForm()
        {
            InitializeComponent();
        }

        private void WriteResult(string text)
        {
            BeginInvoke((Action)delegate ()
            {
                string line = text + Environment.NewLine;
                singletonFlowResult.AppendText(line);
            });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            singletonFlowResult.Clear();

            runner = new Runner();
            runner.MessageReceived += OnMessageReceived;

            int numberOfUsers = int.Parse(textBoxNumberOfUsers.Text);
            int maxNumberOfDocuments = int.Parse(textBoxMaxDocuments.Text);
            runner.Run(numberOfUsers, maxNumberOfDocuments);
        }

        private void OnMessageReceived(object sender, MessageReceivedEventArgs args)
        {
            WriteResult(args.Message);
        }
    }
}
