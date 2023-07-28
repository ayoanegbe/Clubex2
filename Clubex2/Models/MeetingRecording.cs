using Clubex2.Models.Enums;

namespace Clubex2.Models
{
    public class MeetingRecording
    {
        public int MeetingRecordingId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string FilePath { get; set; }
        public MediaType MediaType { get; set; } = MediaType.Audio;
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
