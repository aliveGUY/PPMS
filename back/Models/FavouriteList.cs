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
        public int UserId { get; set; }
        public required User User { get; set; }

        public int PlaygroundId { get; set; }
        public required Playground Playground { get; set; }
    }
}