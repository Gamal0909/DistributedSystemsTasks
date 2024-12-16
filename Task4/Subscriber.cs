using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public partial class Subscriber : Form
    {
        private string subscriberName { get; set; }
        private bool isSubscribed { get; set; }
        private Publisher publisher { get; set; }

        public Subscriber(Publisher publisher)
        {
            InitializeComponent();
            isSubscribed = false;
            this.publisher = publisher;
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                MessageBox.Show("Please enter a valid name for the subscriber!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Startbtn.Enabled = false;
            Subscriberbtn.Enabled = true;
            Nametxt.Enabled = false;
            subscriberName = Nametxt.Text;
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            
            if (!isSubscribed)
            {
                Subscriberbtn.Text = "Subscribe";
                Subscriberbtn.BackColor = Color.Red;
                Subscriberbtn.ForeColor = Color.White;
            }
            else
            {
                Subscriberbtn.Text = "Unsubscribe";
                Subscriberbtn.BackColor = Color.Gray;
                Subscriberbtn.ForeColor = Color.Black;
            }
        }

        private void Subscribe(Publisher publisher)
        {
            if (!isSubscribed)
            {
                publisher.publisherEvent += Update;
                isSubscribed = true;
                publisher.DoAction(subscriberName, "subscribed");
                UpdateGUI();
            }
        }

        private void Unsubscribe(Publisher publisher)
        {
            if (isSubscribed)
            {
                publisher.publisherEvent -= Update;
                isSubscribed = false;
                publisher.DoAction(subscriberName, "unsubscribed");
                UpdateGUI();
            }
        }

        private void Update(object sender, EventArgument e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                SLogtxt.AppendText($"Message received: {e.message}\n");
            }));

            if (sender is Publisher pub)
            {
                pub.WriteLog($"{subscriberName} received message: {e.message}");
            }
        }
        private void Subscriberbtn_Click(object sender, EventArgs e)
        {
            if (isSubscribed)
            {
                Unsubscribe(publisher);
            }
            else
            {
                Subscribe(publisher);
            }
        }
    }
}
