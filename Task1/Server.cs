using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Task1
{
    public partial class Server : Form
    {
        UdpClient server;
        IPEndPoint endPoint;

        public Server()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void Server_Load(object sender, EventArgs e) { }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                int serverPort = int.Parse(txtServerPort.Text);
                server = new UdpClient(serverPort);
                IPAddress ipAddress = IPAddress.Any;
                endPoint = new IPEndPoint(ipAddress, 0);
                WriteLog("Server Started on port " + serverPort + "...");
                Thread thread = new Thread(new ThreadStart(ServerStart));
                thread.Start();
                Start.Enabled = false;
            }
            catch (FormatException)
            {
                WriteLog("Invalid port number. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                WriteLog($"Unexpected error: {ex.Message}");
            }
        }

        private void WriteLog(string msg)
        {
            
            this.BeginInvoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(msg + Environment.NewLine);
            }));
        }

        private void ServerStart()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = server.Receive(ref endPoint);
                    string receivedMessage = Encoding.Unicode.GetString(buffer);
                    //WriteLog($"Received raw message: {receivedMessage}");

                    string[] msg = receivedMessage.Split(':');

                    // Ensure the message has at least three parts
                    if (msg.Length < 3)
                    {
                        WriteLog("Invalid message format. Expected: 'port:hostname:message'.");
                        continue; // Skip processing this message
                    }

                    // Extract message components
                    string clientPort = msg[0];
                    string hostName = msg[1];
                    string clientMessage = msg[2];

                    // Log components
                    WriteLog($"Client Port: {clientPort}");
                    WriteLog($"Host: {hostName}");
                    WriteLog($"Message: {clientMessage}");

                   //Take a server message
                    string serverResponse = txtServerMessage.Text;
                    if (string.IsNullOrWhiteSpace(serverResponse))
                        serverResponse = "Default Server Response";
                    //Send to Client
                    byte[] responseBuffer = Encoding.Unicode.GetBytes(serverResponse);
                    server.Send(responseBuffer, responseBuffer.Length, hostName, int.Parse(clientPort));
                }
                catch (SocketException ex)
                {
                    WriteLog($"SocketException: {ex.Message}. Client may have closed the connection.");
                }
                catch (Exception ex)
                {
                    WriteLog($"Unexpected error: {ex.Message}");
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }
    }
}
