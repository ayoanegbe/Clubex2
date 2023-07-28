using Clubex2.Models.Enums;

namespace Clubex2.Models
{
    public class CommitteeMember
    {
        public int CommitteeMemberId { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public CommitteeDesignation Designation { get; set; }
    }
}
