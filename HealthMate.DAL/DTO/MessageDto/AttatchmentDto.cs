using HealthMate.DAL.Enums;

namespace HealthMate.DAL.DTO.MessageDto{
    public class AttachmentDto
    {
        public AttatchmentType AttatchmentType { get; set; }
        public string AttatchmentId { get; set; } = null!;
    }
}