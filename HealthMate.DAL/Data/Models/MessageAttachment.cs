using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Data.Models{
    public class MessageAttachment{
        public int Id { get; set; }
        public int MessageId { get; set; }
        public AttatchmentType AttatchmentType { get; set; }
        public string AttatchmentId { get; set; } = null!;
        
        public Message Message { get; set; } = null!;
    }
}