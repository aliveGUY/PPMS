using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.Voting;
using back.Models;

namespace back.Interfaces
{
    public interface IVotingRepository
    {
        Task<List<Voting>> GetAllAsync();
        Task<Voting?> GetByIdAsync(int id);
        Task<Voting> CreateAsync(Voting votVotingModel);
        Task<Voting?> UpdateAsync(int id, UpdateVotingDto votVotingDto);
        Task<Voting?> DeleteAsync(int id);
    }
}