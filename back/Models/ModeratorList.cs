using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class ModeratorList
    {
        public int Id { get; set; }

        // Foreign Keys and Navigation Properties
        public int PlaygroundId { get; set; }
        public required Playground Playground { get; set; }

        public ICollection<int> UserId { get; set; } = new List<int>();
        public ICollection<User> User { get; set; } = new List<User>();
    }
}