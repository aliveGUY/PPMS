using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.DTOs.ModeratorList
{
    public class CreateModeratorListDto
    {
        public int PlaygroundId { get; set; }

        public ICollection<int> UserId { get; set; } = new List<int>();
    }
}