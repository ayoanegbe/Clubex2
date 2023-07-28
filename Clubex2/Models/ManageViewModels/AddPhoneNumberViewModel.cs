using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Clubex2.Models.ManageViewModels
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
