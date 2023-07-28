using Clubex2.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public Title Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string PostalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Anniversary { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
