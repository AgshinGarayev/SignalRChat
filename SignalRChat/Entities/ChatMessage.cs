using System.ComponentModel.DataAnnotations;

namespace SignalRChat.Entities
{
    public class ChatMessage
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
