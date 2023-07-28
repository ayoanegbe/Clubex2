namespace Clubex2.Models
{
    public class MeetingAttendee
    {
        public int MeetingAttendeeId { get; set; }
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
        public int Memberid { get; set; }
        public Member Member { get; set; }
    }
}
