using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class ExecutivePosition
    {
        [Key]
        public int ExecutivePositionId { get; set; }
        [Required]
        [Display(Name = "Position")]
        public string PositionName { get;}
    }
}
