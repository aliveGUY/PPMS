using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using back.Constants.Enums;

namespace back.Models
{
    public class Voting
    {
        public int Id { get; set; }
        public string Agenda { get; set; } = string.Empty;
        public EVotingCategory VotingCategory { get; set; }

        // Foreign Key and Navigation Property
        public int PlaygroundId { get; set; }
        public required Playground Playground { get; set; }

        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}