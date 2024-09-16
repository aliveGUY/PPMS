using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Constants.Enums;

namespace back.DTOs.VoteDto
{
    public class CreateVoteDto
    {
        public int VotingId { get; set; }
        public EVoteChoice VoteChoice { get; set; }
        public int UserId { get; set; }
    }
}