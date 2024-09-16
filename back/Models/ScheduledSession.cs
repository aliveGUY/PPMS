using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using back.Constants.Enums;

namespace back.Models
{
    public class ScheduledSession
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; } = string.Empty;
        public EScheduleType EventType { get; set; }
        public EScheduleRepetition Repeat { get; set; }

        // Foreign Key and Navigation Property
        public required int PlaygroundId { get; set; }
        public required Playground Playground { get; set; }

        public ICollection<int> ParticipantIds { get; set; } = new List<int>();
        public ICollection<User> Participants { get; set; } = new List<User>();
    }
}