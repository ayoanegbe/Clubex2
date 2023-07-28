using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Event
    {
        [Key]
        public string EventId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }
        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string Note { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public string AddedBy { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
