namespace Clubex2.Models
{
    public class EmailSettings
    {
        public string PrimaryDomain { get; set; }
        public int PrimaryPort { get; set; }
        public string UsernameEmail { get; set; }
        public string UsernamePassword { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
        public string CcEmail { get; set; }
        public string Enquiry { get; set; }
        public string Resume { get; set; }
        public string Subscription { get; set; }
        public string Upload { get; set; }
    }
}
