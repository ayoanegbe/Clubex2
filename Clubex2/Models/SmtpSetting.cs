using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Clubex2.Models
{
    public class SmtpSetting
    {
        [Key]
        public int SmtpSettingId { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string Host { get; set; }
        [Display(Name = "Host IP")]
        public string HostIP { get; set; }
        [Display(Name = "Port Number")]
        public string PortNumber { get; set; }
        public string Password { get; set; }
    }
}
