using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    public partial class Client : Form
    {
        private UdpClient udpClient;

        public Client()
        {
            InitializeComponent();
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            try
            {
                int serverPort = int.Parse(txtServerPort.Text);
                int clientPort = int.Parse(txtClientPortnum.Text);
                string hostname = txtHostName.Text;

                if (string.IsNullOrWhiteSpace(hostname))
                    hostname = "localhost";

                // Reuse the same UDP client
                if (udpClient == null)
                    udpClient = new UdpClient(clientPort);

                // Prepare the message
                string message = $"{clientPort}:{hostname}:{txtmsg.Text}";
                byte[] buffer = Encoding.Unicode.GetBytes(message);

                // Send the message
                await udpClient.SendAsync(buffer, buffer.Length, hostname, serverPort);
                WriteLog($"Message sent to server: {message}");

                // Receive the server response
                var result = await udpClient.ReceiveAsync();
                string serverMessage = Encoding.Unicode.GetString(result.Buffer);

                WriteLog($"Server Message: {serverMessage}");
            }
            catch (FormatException)
            {
                WriteLog("Error: Please enter valid port numbers.");
            }
            catch (SocketException ex)
            {
                WriteLog($"Socket error: {ex.Message}");
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
    }
}
