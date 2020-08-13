using System;
using System.Net;

namespace HenE.WebSocketExample.WebSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server");
            Server server = new Server(IPAddress.Parse("127.0.0.1"),5000);
            server.Start();
            Console.Read();
        }
    }
}
