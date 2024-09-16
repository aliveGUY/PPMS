using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.DTOs.ModeratorList
{
    public class UpdateModeratorListDto
    {
        public ICollection<int> UserId { get; set; } = new List<int>();

    }
}