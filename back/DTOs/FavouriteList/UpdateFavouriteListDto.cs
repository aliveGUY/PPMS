using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.DTOs.FavouriteList
{
    public class UpdateFavouriteListDto
    {
        public ICollection<int> PlaygroundId { get; set; } = new List<int>();
    }
}