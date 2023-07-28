using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Clubex2.Models
{
    public class ContentSearch
    {
        [Key]
        public int ContentSerchId { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Html)]
        public string Content { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
