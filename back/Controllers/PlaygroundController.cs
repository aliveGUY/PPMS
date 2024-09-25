using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Data;
using back.DTOs.Playground;
using back.Interfaces;
using back.Mappers;
using back.Models;
using Microsoft.AspNetCore.Mvc;

namespace back.Controllers
{
    [Route("api/playground")]
    [ApiController]
    public class PlaygroundController(IPlaygroundRepository playgroundRepo) : ControllerBase
    {
        private readonly IPlaygroundRepository _playgroundRepo = playgroundRepo;

        [HttpGet]
        public async Task<IActionResult> GetPlaygrounds(
            [FromQuery] string? address,
            [FromQuery] string? city,
            [FromQuery] string? province,
            [FromQuery] string? country)
        {
            Console.WriteLine($"address: {address}\ncity: {city}\nprovince: {province}\ncountry: {country}");

            IEnumerable<Playground> playgrounds = await _playgroundRepo.GetAllAsync();
            string scope = "all";

            if (!string.IsNullOrEmpty(address))
            {
                scope = "address";
                playgrounds = await _playgroundRepo.SearchByAddressAsync(address);
            }

            if (!playgrounds.Any() && !string.IsNullOrEmpty(city))
            {
                scope = "city";
                playgrounds = await _playgroundRepo.SearchByCityAsync(city);
            }

            if (!playgrounds.Any() && !string.IsNullOrEmpty(province))
            {
                scope = "province";
                playgrounds = await _playgroundRepo.SearchByProvinceAsync(province);
            }

            if (!playgrounds.Any() && !string.IsNullOrEmpty(country))
            {
                scope = "country";
                playgrounds = await _playgroundRepo.SearchByCountryAsync(country);
            }

            var playgroundDtos = playgrounds.Select(s => s.ToPlaygroundDto());

            var result = new SearchPlaygroundDto
            {
                Playgrounds = playgroundDtos,
                Scope = scope
            };

            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var playground = await _playgroundRepo.GetByIdAsync(id);
            if (playground == null) return NotFound();
            return Ok(playground.ToPlaygroundDto());
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