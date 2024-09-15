using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.Playground;
using back.Models;

namespace back.Interfaces
{
    public interface IPlaygroundRepository
    {
        Task<List<Playground>> GetAllAsync();
        Task<Playground?> GetByIdAsync(int id);
        Task<Playground> CreateAsync(Playground playgroundModel);
        Task<Playground?> UpdateAsync(int id, UpdatePlaygroundDto playgroundDto);
        Task<Playground?> DeleteAsync(int id);
    }
}