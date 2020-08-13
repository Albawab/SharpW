using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _00_GetStart.ChatHubs
{
    public class ChatHub : Hub
    {
        
        public async Task SendMessage()
        {

            while (true)
            {
                int second = DateTime.Now.Second;
                Thread.Sleep(2000);
                await Clients.All.SendAsync("ReceiveMessage", second);
            }

        }
    }
}
