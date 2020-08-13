using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {

        private static byte[] buffer = new byte[1024];
        private static List<Socket> ClientSocket = new List<Socket>();

        static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.Title = "Server";
            SetupServer();
            Console.ReadKey();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Setting up server....");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 5000));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }
        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            ClientSocket.Add(socket);
            Console.WriteLine("Client connected.");
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            foreach (Socket client in ClientSocket)
            {
                Sender(AR, client);
            }
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }
        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(buffer, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);
            Console.WriteLine("Text recevied: " + text);
            string response = string.Empty;
            response = DateTime.Now.ToLongTimeString();

            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            /*            Sender(AR);*/
            // socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

        }


        private static void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        private static void Sender(IAsyncResult AR,Socket client)
        {

            string response = string.Empty;
                response = DateTime.Now.ToLongTimeString();

            byte[] data = Encoding.ASCII.GetBytes(response);
            client.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), client);
        }
    }
}
