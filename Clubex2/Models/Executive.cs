using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Executive
    {
        [Key]
        public int ExecutiveId { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ExecutivePositionId { get; set; }
        public ExecutivePosition Postion { get; set; }
        public int OganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
