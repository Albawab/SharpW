using System;
using System.Net.WebSockets;

namespace HenE.WebSocketExample.WebSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoi i am in the program van de client");
            Client client = new Client("localhost",5000);
            client.Start();

            client.SendMessage("Hello iam here !!");
            Console.ReadKey();
        }
    }
}
