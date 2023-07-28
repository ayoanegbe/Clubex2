using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Committee
    {
        [Key]
        public int CommitteeId { get; set; }
        public string Name { get; set;}
        public string Description { get; set;}
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
