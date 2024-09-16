using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.VoteDto;
using back.Interfaces;
using back.Models;

namespace back.Repository
{
    public class VoteRepository : IVoteRepository
    {
        public Task<Vote> CreateAsync(Vote votVoteModel)
        {
            throw new NotImplementedException();
        }

        public Task<Vote?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vote>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Vote?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Vote?> UpdateAsync(int id, UpdateVoteDto votVoteDto)
        {
            throw new NotImplementedException();
        }
    }
}