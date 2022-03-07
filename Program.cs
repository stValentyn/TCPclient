using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace tcpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcp = new TcpClient("localhost", 9091);

            tcp.Connect("localhost", 9090);
            tcp.GetStream().Write(Encoding.ASCII.GetBytes("Hello TCP listener!"),32,32);

            tcp.Close();
        }
    }
}
