using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.DTOs.Playground
{
  public class SearchPlaygroundDto
  {
    public IEnumerable<PlaygroundDto> Playgrounds { get; set; } = [];
    public required string Scope { get; set; }

  }
}