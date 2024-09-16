using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.DTOs.FavouriteListDto
{
    public class FavouriteListDto
    {
        public int Id { get; set; }

        public required int UserId { get; set; }

        public ICollection<int> PlaygroundId { get; set; } = new List<int>();
    }
}