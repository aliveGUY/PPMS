using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Data;
using back.DTOs.Playground;
using back.Interfaces;
using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back.Repository
{
    public class PlaygroundRepository(ApplicationDBContext context) : IPlaygroundRepository
    {
        private readonly ApplicationDBContext _context = context;

        public async Task<Playground> CreateAsync(Playground playgroundModel)
        {
            await _context.Playground.AddAsync(playgroundModel);
            await _context.SaveChangesAsync();
            return playgroundModel;
        }

        public async Task<Playground?> DeleteAsync(int id)
        {
            var playgroundModel = await _context.Playground.FirstOrDefaultAsync(x => x.Id == id);
            if (playgroundModel == null) return null;
            _context.Playground.Remove(playgroundModel);
            await _context.SaveChangesAsync();
            return playgroundModel;
        }

        public async Task<List<Playground>> GetAllAsync()
        {
            return await _context.Playground.ToListAsync();
        }

        public async Task<Playground?> GetByIdAsync(int id)
        {
            return await _context.Playground.FindAsync(id);
        }

        public async Task<Playground?> UpdateAsync(int id, UpdatePlaygroundDto playgroundDto)
        {
            var playgroundModel = await _context.Playground.FirstOrDefaultAsync(x => x.Id == id);
            if (playgroundModel == null) return null;

            playgroundModel.Name = playgroundDto.Name;
            playgroundModel.Address = playgroundDto.Address;
            playgroundModel.Images = playgroundDto.Images;

            await _context.SaveChangesAsync();

            return playgroundModel;
        }
    }
}