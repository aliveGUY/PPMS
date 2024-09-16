using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Constants.Enums;

namespace back.DTOs.ScheduledSession
{
    public class CreateScheduledSessionDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; } = string.Empty;
        public EScheduleType EventType { get; set; }
        public EScheduleRepetition Repeat { get; set; }

        public required int PlaygroundId { get; set; }

        public ICollection<int> ParticipantIds { get; set; } = new List<int>();
    }
}