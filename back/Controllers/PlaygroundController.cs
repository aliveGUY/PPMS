using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Data;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [Route("api/playground")]
    [ApiController]
    public class PlaygroundController(ApplicationDBContext context) : ControllerBase
    {
        private readonly ApplicationDBContext _context = context;

        [HttpGet]
        public IActionResult GetAll()
        {
            var playgrounds = _context.Playground.ToList();
            return Ok(playgrounds);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var playground = _context.Playground.Find(id);
            if (playground == null) return NotFound();
            return Ok(playground);
        }
    }
}