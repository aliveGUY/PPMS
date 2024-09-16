using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class FavouriteList
    {
        public int Id { get; set; }

        // Foreign Keys and Navigation Properties
        public required int UserId { get; set; }
        public required User User { get; set; }

        public ICollection<int> PlaygroundId { get; set; } = new List<int>();
        public ICollection<Playground> Playground { get; set; } = new List<Playground>();

    }
}