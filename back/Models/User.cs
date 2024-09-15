using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<FavouriteList> FavouriteLists { get; set; } = new List<FavouriteList>();
        public ICollection<Moderator> Moderators { get; set; } = new List<Moderator>();
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
        public ICollection<ScheduledSessionParticipants> ScheduledEventParticipants { get; set; } = new List<ScheduledSessionParticipants>();
    }
}