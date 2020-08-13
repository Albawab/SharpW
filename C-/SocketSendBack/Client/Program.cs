using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{
    class Program
    {
        static Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.Title = "Client";
            LoopConnect();
            SendLoop("o");
            Ontvanger();
            Console.ReadLine();
        }

        private static void SendLoop(String message)
        {
                Thread.Sleep(1000);
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                ClientSocket.Send(buffer);
        }

        private static void Ontvanger()
        {
                byte[] receivedBuffer = new byte[1024];
                int rec = ClientSocket.Receive(receivedBuffer);

                byte[] data = new byte[rec];
                Array.Copy(receivedBuffer, data, rec);
                Console.WriteLine("Received" + Encoding.ASCII.GetString(data));
        }

        private static void LoopConnect()
        {
            int attempts = 0;
            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;

                    ClientSocket.Connect(IPAddress.Loopback, 5000);
                }
                catch (SocketException)
                {
                    Console.Clear();
                    Console.WriteLine("connection attempts :" + attempts.ToString());
                }
            }
            Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}
