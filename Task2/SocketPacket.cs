using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SocketPacket
    {
        public Socket client { get; set; }
        public byte[] buffer { get; set; }
        public SocketPacket(Socket client)
        {
            this.client = client;
            this.buffer = new byte[1024];
        }
    }
}
