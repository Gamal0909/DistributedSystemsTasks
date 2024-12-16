using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Task2
{
    public partial class Client : Form
    {
        private Socket client;
        private byte[] buffer = new byte[1024];

        public Client()
        {
            InitializeComponent();
            SetIpAddress();
        }

        private void SetIpAddress()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(hostName); // Updated to use GetHostEntry
            //Iptxt.Text = ipHost.AddressList[0].ToString(); // Use the first IP address
        }

        private void UpdateGUI(bool isConnected)
        {
            Connectbtn.Enabled = !isConnected;
            Sendbtn.Enabled = isConnected;
            lblStatus.Text = isConnected ? "Connected" : "Disconnected";
            lblStatus.ForeColor = isConnected ? Color.Green : Color.Red;
            Iptxt.Enabled = !isConnected;
            portnumtxt.Enabled = !isConnected;
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                int portnum = int.Parse(portnumtxt.Text);
                IPAddress ip = IPAddress.Parse(Iptxt.Text);

                // Debug info to validate input
                MessageBox.Show($"Connecting to {ip}:{portnum}");

                client.Connect(new IPEndPoint(ip, portnum));
                UpdateGUI(true);
                WriteLog("Connected to server..." + Environment.NewLine);

                WaitingForData(client);
            }
            catch (SocketException ex)
            {
                WriteLog($"SocketException: {ex.Message}" + Environment.NewLine);
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WaitingForData(Socket client)
        {
            client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                int bytesRead = client.EndReceive(ar); // Correctly handle the number of bytes received
                if (bytesRead > 0 && bytesRead < 1024)
                {
                    string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                    WriteLog($"Server said: {msg}");
                }

                // Return
                WaitingForData(client);
            }
            catch (SocketException ex)
            {
                WriteLog($"SocketException: {ex.Message}" + Environment.NewLine);
            }
            catch (ObjectDisposedException)
            {
                WriteLog("Connection closed by server." + Environment.NewLine);
            }
        }

        private void WriteLog(string msg)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                logtxt.AppendText(msg + Environment.NewLine);
            }));
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = msgtxt.Text;
                buffer = Encoding.Unicode.GetBytes(msg);
                client.Send(buffer);
                WriteLog("You said: " + msg);
            }
            catch (SocketException ex)
            {
                WriteLog($"SocketException: {ex.Message}" + Environment.NewLine);
            }
        }

        private void Client_Load(object sender, EventArgs e) { }
    }
}
