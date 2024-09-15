using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using back.Constants.Enums;

namespace back.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public EVoteChoice VoteChoice { get; set; }

        // Foreign Keys and Navigation Properties
        public int VotingId { get; set; }
        public required Voting Voting { get; set; }

        public int UserId { get; set; }
        public required User User { get; set; }
    }
}