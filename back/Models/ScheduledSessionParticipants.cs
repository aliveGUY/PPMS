using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using back.Constants.Enums;

namespace back.Models
{
    public class ScheduledSessionParticipants
    {
        public int Id { get; set; }
        public EParticipantRole Role { get; set; }

        // Foreign Keys and Navigation Properties
        public int EventId { get; set; }
        public required ScheduledSession Event { get; set; }

        public int UserId { get; set; }
        public required User User { get; set; }


    }
}