using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int CommunicationId { get; set; }
        public Communication Communication { get; set; }
        public int MemberId { get;set; }
        public Member Member { get;set; }
    }
}
