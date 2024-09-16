using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class Playground
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();

        // Voting thresholds grouped for clarity
        public int RequiredVotesElectModerator { get; set; }
        public int RequiredVotesDismissModerator { get; set; }
        public int RequiredVotesScheduleSession { get; set; }
        public int RequiredVotesDiscardSession { get; set; }
        public int RequiredVotesEditPlayground { get; set; }
        public int RequiredVotesDeletePlayground { get; set; }

        // Navigation properties
        public ICollection<ScheduledSession> ScheduledEvents { get; set; } = new List<ScheduledSession>();
        public ICollection<FavouriteList> FavouriteLists { get; set; } = new List<FavouriteList>();
        public ICollection<ModeratorList> Moderators { get; set; } = new List<ModeratorList>();
        public ICollection<Voting> Votings { get; set; } = new List<Voting>();
    }

}