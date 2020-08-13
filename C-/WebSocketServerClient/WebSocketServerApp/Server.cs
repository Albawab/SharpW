using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HenE.WebSocketExample.WebSocketClient
{
    public class Server
    {


        private TcpListener server = null;

        public int port { get; private set; }

        public IPAddress iPAddress { get; private set; }

        public Server(IPAddress iPAddress, int poort)
        {
            this.iPAddress = iPAddress;
            this.port = poort;
            server = new TcpListener(iPAddress, port);
        }

        public void Start()
        {
            server.Start();
            while (true)
            {
                TcpClient tcpClient = server.AcceptTcpClient();
                byte[] receivedBuffer = new byte[5000];
                NetworkStream stream = tcpClient.GetStream();

                stream.Read(receivedBuffer,0,receivedBuffer.Length);
                StringBuilder msg = new StringBuilder();

                foreach(byte byt in receivedBuffer)
                {
                    if (byt.Equals(00))
                    {
                        break;
                    }
                    else
                    {
                        msg.Append(Convert.ToChar(byt).ToString());
                    }
                }
                Console.WriteLine(msg.ToString() + msg.Length);
            }
        }

    }
}
