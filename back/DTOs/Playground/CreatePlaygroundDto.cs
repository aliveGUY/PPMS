using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.DTOs.Playground
{
    public class CreatePlaygroundDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();
    }
}