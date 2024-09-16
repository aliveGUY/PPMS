using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Constants.Enums;

namespace back.DTOs.VoteDto
{
    public class UpdateVoteDto
    {
        public EVoteChoice VoteChoice { get; set; }
    }
}