using Clubex2.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }
        [Display(Name = "Account Type")]
        public AccountType AccountType { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Last Modified By")]
        public string LastModifiedBy { get; set;}
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public AccountOrientation DebitCredit { get; set; }
    }
}
