using Clubex2.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public Status SubscriptionStatus { get; set; }
    }
}
