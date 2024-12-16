using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class Publisher : Form
    {
        public string name { get; set; }
        public event EventHandler<EventArgument> publisherEvent;

        public Publisher()
        {
            InitializeComponent();
        }

        
        public void Notify(string msg)
        {
            EventArgument eventArgument = new EventArgument($"{name} says: {msg}");
            publisherEvent?.Invoke(this, eventArgument); // Notify only subscribed clients
            WriteLog("Notification sent: " + eventArgument.message);
        }
        public void DoAction(string subscriberName, string action)
        {
            WriteLog($"{subscriberName} has {action}.");
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                MessageBox.Show("Please enter a valid name for the publisher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            name = Nametxt.Text;
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            Startbtn.Enabled = false;
            Newbtn.Enabled = true;
            Nametxt.Enabled = false;
            WriteLog("Publisher Ready...");
        }

        public void WriteLog(string msg)
        {
            this.BeginInvoke(new MethodInvoker(() => Logtxt.AppendText(msg + Environment.NewLine)));
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = new Subscriber(this);
            subscriber.Show();
        }

        private void Notifybtn_Click(object sender, EventArgs e)
        {
            try
            {
                string msg =Msgtxt.Text;
                Notify(msg);
            }
            catch {
                MessageBox.Show("Cant Notify :(");
            }
        }
    }
}
