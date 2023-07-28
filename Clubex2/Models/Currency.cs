using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }
        [Display(Name = "Currency Name")]
        public string CurrencyName { get; set; }
        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; }
        [Display(Name = "Currency Symbol")]
        public string CurrencySymbol { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
