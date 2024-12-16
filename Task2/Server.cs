using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Task2
{
    public partial class Server : Form
    {
        private Socket server;
        private List<Socket> Clients = new List<Socket>();

        public Server()
        {
            InitializeComponent();
        }

        private void UpdateGUI(bool isConnected)
        {
            Startbtn.Enabled = !isConnected;
            Sendbtn.Enabled = isConnected;
            lblStatus.Text = isConnected ? "Server Started" : "Server Stopped";
            lblStatus.ForeColor = isConnected ? Color.Green : Color.Red;
            Porttxt.Enabled = !isConnected;
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                int portnum = int.Parse(Porttxt.Text);
                server.Bind(new IPEndPoint(IPAddress.Any, portnum));
                server.Listen(5);

                UpdateGUI(true);
                WriteLog($"Server started on port {portnum}" + Environment.NewLine);

                server.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Socket Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteLog($"SocketException: {ex.Message}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteLog($"Exception: {ex.Message}" + Environment.NewLine);
            }
        }

        private void OnClientConnect(IAsyncResult ar)
        {
            try
            {
                Socket client = server.EndAccept(ar);
                Clients.Add(client);

                // Get client's IP and port
                string clientIdentifier = ((IPEndPoint)client.RemoteEndPoint).Address.ToString() + ":" +
                                          ((IPEndPoint)client.RemoteEndPoint).Port;

                // Add client to ComboBox on the UI thread
                this.Invoke((MethodInvoker)delegate
                {
                    if (!clientListcbox.Items.Contains(clientIdentifier))
                    {
                        clientListcbox.Items.Add(clientIdentifier);
                    }
                });

                WriteLog($"Client connected: {clientIdentifier}" + Environment.NewLine);

                ReadyForData(client);
                server.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
            catch (SocketException ex)
            {
                WriteLog($"SocketException during client connection: {ex.Message}" + Environment.NewLine);
            }
        }

        private void ReadyForData(Socket client)
        {
            try
            {
                SocketPacket packet = new SocketPacket(client);
                client.BeginReceive(packet.buffer, 0, packet.buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), packet);
            }
            catch (SocketException ex)
            {
                WriteLog($"Error preparing to receive data: {ex.Message}" + Environment.NewLine);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                SocketPacket packet = (SocketPacket)ar.AsyncState;
                int bytesRead = packet.client.EndReceive(ar);

                if (bytesRead > 0 && bytesRead < 1024)
                {
                    string msg = Encoding.Unicode.GetString(packet.buffer, 0, bytesRead);
                    WriteLog($"Client said: {msg}" + Environment.NewLine);
                }
                // Continue listening for data
                ReadyForData(packet.client);
            }
            catch (SocketException ex)
            {
                WriteLog($"Error during data reception: {ex.Message}" + Environment.NewLine);
            }
            catch (ObjectDisposedException)
            {
                WriteLog("Connection closed unexpectedly by client." + Environment.NewLine);
            }
        }

        private void WriteLog(string msg)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(msg + Environment.NewLine);
            }));
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            if (clientListcbox.SelectedItem == null)
            {
                MessageBox.Show("Please select a client from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedClient = clientListcbox.SelectedItem.ToString();
            string[] clientParts = selectedClient.Split(':');


            //Debug
            if (clientParts.Length != 2)
            {
                MessageBox.Show("Invalid client selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedIp = clientParts[0];
            int selectedPort = int.Parse(clientParts[1]);

            // Find the corresponding client
            Socket targetClient = Clients.FirstOrDefault(client =>
                ((IPEndPoint)client.RemoteEndPoint).Address.ToString() == selectedIp &&
                ((IPEndPoint)client.RemoteEndPoint).Port == selectedPort);

            if (targetClient == null)
            {
                MessageBox.Show("Selected client is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msg = msgtxt.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            try
            {
                targetClient.Send(buffer);
                WriteLog($"Message sent to {selectedClient}: {msg}");
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Failed to send message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteLog($"SocketException: {ex.Message}" + Environment.NewLine);
            }
        }
    }
}