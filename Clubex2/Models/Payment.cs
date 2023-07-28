using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Amount { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
