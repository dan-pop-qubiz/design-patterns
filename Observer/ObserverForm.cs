using System;
using System.Windows.Forms;

namespace DesignPatterns.Observer
{
    public partial class ObserverForm : Form
    {
        public Sport steauaDinamo;
        public Sport interMilan;
        public ITVStation proTV;
        public ITVStation tvr;

        public ObserverForm()
        {
            InitializeComponent();
        }

        private void ObserverForm_Load(object sender, EventArgs e)
        {
            steauaDinamo = new Football("Steaua", "Dinamo");
            interMilan = new Football("Inter", "Milan");

            proTV = new TVStation("ProTV");
            tvr = new TVStation("TVR");

            steauaDinamo.AddTVStation(proTV);
            steauaDinamo.AddTVStation(tvr);

            interMilan.AddTVStation(proTV);
            interMilan.AddTVStation(tvr);

            proTV.Notify += OnNotify;
            tvr.Notify += OnNotify;
        }

        private void OnNotify(object sender, NotifyEventArgs args)
        {
            string line = args.Message + Environment.NewLine;

            switch (args.Observer.Name)
            {
                case "ProTV":
                    textBoxProTV.AppendText(line);
                    break;
                case "TVR":
                    textBoxTVR.AppendText(line);
                    break;
            }
        }

        private void startSteauaDinamo_Click(object sender, EventArgs e)
        {
            steauaDinamo.Start();
            textBoxSteauaDinamo.Text = "0-0";
        }

        private void stopSteauaDinamo_Click(object sender, EventArgs e)
        {
            steauaDinamo.Stop();
            textBoxSteauaDinamo.Clear();
        }

        private void updateSteauaDinamo_Click(object sender, EventArgs e)
        {
            string score = textBoxSteauaDinamo.Text;
            steauaDinamo.Score(score);
        }

        private void startInterMilan_Click(object sender, EventArgs e)
        {
            interMilan.Start();
            textBoxInterMilan.Text = "0-0";
        }

        private void stopInterMilan_Click(object sender, EventArgs e)
        {
            interMilan.Stop();
            textBoxInterMilan.Clear();
        }

        private void updateInterMilan_Click(object sender, EventArgs e)
        {
            string score = textBoxInterMilan.Text;
            interMilan.Score(score);
        }
    }
}