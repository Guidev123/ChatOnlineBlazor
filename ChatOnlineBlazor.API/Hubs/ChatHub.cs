using Microsoft.AspNetCore.SignalR;

namespace ChatOnlineBlazor.API.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Broadcast(string username, string message)
        {
            await Clients.All.SendAsync("Broadcast", username, message);
        }
    }
}
