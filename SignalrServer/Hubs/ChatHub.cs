using Microsoft.AspNetCore.SignalR;

namespace SignalrServer.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendChatNotification(string message, string username)
        {
            string response = "<"+username+"> " + message;
            await Clients.All.SendAsync("showString", response);
        }
    }
}
