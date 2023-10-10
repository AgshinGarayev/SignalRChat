using Microsoft.EntityFrameworkCore;
using SignalRChat.Entities;

namespace SignalRChat.DAL
{
    public class MessageDbContext:DbContext
    {
        public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options)
        {
            
        }

        DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
