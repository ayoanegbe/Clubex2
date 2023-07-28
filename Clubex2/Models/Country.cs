using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
}
