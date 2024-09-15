using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Data;
using back.DTOs.Playground;
using back.Interfaces;
using back.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [Route("api/playground")]
    [ApiController]
    public class PlaygroundController(IPlaygroundRepository playgroundRepo) : ControllerBase
    {
        private readonly IPlaygroundRepository _playgroundRepo = playgroundRepo;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var playgrounds = await _playgroundRepo.GetAllAsync();
            var playgroundDtos = playgrounds.Select(s => s.ToPlaygroundDto());
            return Ok(playgroundDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var playground = await _playgroundRepo.GetByIdAsync(id);
            if (playground == null) return NotFound();
            return Ok(playground);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePlaygroundDto playgroundDto)
        {
            var playgroundModel = playgroundDto.ToPlaygroundFromCreateDto();
            await _playgroundRepo.CreateAsync(playgroundModel);
            return CreatedAtAction(nameof(GetById), new { id = playgroundModel.Id }, playgroundModel.ToPlaygroundDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePlaygroundDto playgroundDto)
        {
            var playgroundModel = await _playgroundRepo.UpdateAsync(id, playgroundDto);
            if (playgroundModel == null) return NotFound();
            return Ok(playgroundModel.ToPlaygroundDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var playgroundModel = await _playgroundRepo.DeleteAsync(id);
            if (playgroundModel == null) return NotFound();
            return NoContent();
        }
    }
}