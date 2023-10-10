using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRChat.DAL;
using SignalRChat.Entities;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly MessageDbContext _dbContext;
        public ChatHub(MessageDbContext dbContext)
        {
            _dbContext = dbContext;            
        }
        public async Task SendMessage(string user, string message)
        {
            var chatMessage = new ChatMessage
            {
                User = user,
                Message = message,
                DateTime = DateTime.UtcNow
            };

            _dbContext.Add(chatMessage);
            await _dbContext.SaveChangesAsync();

            // Broadcast the message to all clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
