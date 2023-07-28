using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Tenant
    {
        [Key]
        public Guid TenantId { get; set; }
        public Guid ApiKey { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}
