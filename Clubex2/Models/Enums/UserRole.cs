using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models.Enums
{
    public enum UserRole
    {
        [Display(Name = "Super Administrator")]
        SuperAdministrator = 0,
        [Display(Name = "Administrator")]
        Administrator = 1,
        [Display(Name = "Local Administrator")]
        LocalAdministrator = 2,
        User = 3,
        Tester = 4
    }
}
