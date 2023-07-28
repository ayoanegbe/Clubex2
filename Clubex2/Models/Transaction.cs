using Clubex2.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Transaction
    {
        [Key]
        public int Transactionid { get; set; }
        [Required]
        public string Description { get; set; }
        [Display(Name = "Transaction Type")]
        public TransactionType TransactionType { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }        
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public string CreatedBy { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
