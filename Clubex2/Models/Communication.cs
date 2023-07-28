using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Communication
    {
        [Key]
        public int CommunicationId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string Message { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
