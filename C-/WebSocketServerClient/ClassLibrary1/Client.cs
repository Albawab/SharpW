using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HenE.WebSocketExample.WebSocketClient
{
    public class Client
    {
        Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
        private TcpClient tcpClient = null;

        public int ServerPoort { get; private set; }

        public string Hostname { get; private set; }

        public Client(string hostname, int serverPoort)
        {
            this.Hostname = hostname;
            this.ServerPoort = serverPoort;
        }

        public void Start()
        {
            tcpClient = new TcpClient(this.Hostname, this.ServerPoort);
        }

        public void Stop()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }

        public void SendMessage(string message)
        {
            System.Console.WriteLine("The message is :" + message);

            int byteCount = Encoding.ASCII.GetByteCount(message);
            byte[] sendDate = new byte[byteCount];
            sendDate = Encoding.ASCII.GetBytes(message);
            NetworkStream stream = tcpClient.GetStream();
            stream.Write(sendDate,0,sendDate.Length);
            stream.Close();

        }
    }
}
