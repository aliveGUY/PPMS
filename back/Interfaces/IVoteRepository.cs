using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.VoteDto;
using back.Models;

namespace back.Interfaces
{
    public interface IVoteRepository
    {
        Task<List<Vote>> GetAllAsync();
        Task<Vote?> GetByIdAsync(int id);
        Task<Vote> CreateAsync(Vote votVoteModel);
        Task<Vote?> UpdateAsync(int id, UpdateVoteDto votVoteDto);
        Task<Vote?> DeleteAsync(int id);
    }
}