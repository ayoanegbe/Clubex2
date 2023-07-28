namespace Clubex2.Models
{
    public class MeetingAgenda
    {
        public int MeetingAgendaId { get; set; }
        public string AgendaItem { get; set; }
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}
