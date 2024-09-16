using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Constants.Enums;
using back.Models;

namespace back.DTOs.Voting
{
    public class CreateVotingDto
    {
        public string Agenda { get; set; } = string.Empty;
        public EVotingCategory VotingCategory { get; set; }
        public int PlaygroundId { get; set; }
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}