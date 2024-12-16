using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Http;
using OperationLibrary;


namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            StartServer();
        }

        private void StartServer()
        {
            try
            {
                // Create and register the HTTP channel
                HttpChannel channel = new HttpChannel(50501);
                ChannelServices.RegisterChannel(channel, false);

                // Register the remote object
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(operation),
                    "Operation",
                    WellKnownObjectMode.Singleton);

                MessageBox.Show("Server started successfully on port 50501.",
                    "Server Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start server: {ex.Message}",
                    "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}