using Clubex2.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Clubex2.Models
{
    public class TransactionDetail
    {
        public int TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }        
        public double Amount { get; set; }
        public AccountOrientation DebitCredit { get; set; }
    }
}
