using OperationLibrary;
using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Client : Form
    {

        private operation remoteOperation;
        public Client()
        {
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                // Create and register the HTTP channel
                HttpChannel channel = new HttpChannel();
                ChannelServices.RegisterChannel(channel, false);

                // Connect to the remote object
                remoteOperation = (operation)Activator.GetObject(
                    typeof(operation),
                    "http://localhost:50501/Operation");
                
                //Debug
                if (remoteOperation == null)
                    throw new Exception("Failed to connect to the remote server.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = GetInput(Xtxt);
                int y = GetInput(Ytxt);
                int z = GetInput(Ztxt);
                Resulttxt.Text = remoteOperation.Add(x, y, z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Subbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = GetInput(Xtxt);
                int y = GetInput(Ytxt);
                int z = GetInput(Ztxt);
                Resulttxt.Text = remoteOperation.Sub(x, y, z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resulttxt_TextChanged(object sender, EventArgs e){}

        private void Mulbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = GetInput(Xtxt);
                int y = GetInput(Ytxt);
                int z = GetInput(Ztxt);
                Resulttxt.Text = remoteOperation.Mul(x, y, z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Divbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = GetInput(Xtxt);
                int y = GetInput(Ytxt);
                int z = GetInput(Ztxt);
                if (y == 0 || z == 0)
                {
                    MessageBox.Show("Can't Div on Zero :)");
                    Ytxt.Focus();
                    return;
                }
                Resulttxt.Text = remoteOperation.Div(x, y, z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rembtn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = GetInput(Xtxt);
                int y = GetInput(Ytxt);
                int z = GetInput(Ztxt);
                Resulttxt.Text = remoteOperation.Rem(x, y, z).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetInput(System.Windows.Forms.TextBox textBox)
        {
            if (!int.TryParse(textBox.Text, out int value))
            {
                MessageBox.Show($"Invalid input in {textBox.Name}. Please enter a valid integer.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                throw new ArgumentException($"Invalid input in {textBox.Name}");
            }
            return value;
        }
    }
}