using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.Voting;
using back.Interfaces;
using back.Models;

namespace back.Repository
{
    public class VotingRepository : IVotingRepository
    {
        public Task<Voting> CreateAsync(Voting votVotingModel)
        {
            throw new NotImplementedException();
        }

        public Task<Voting?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Voting>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Voting?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Voting?> UpdateAsync(int id, UpdateVotingDto votVotingDto)
        {
            throw new NotImplementedException();
        }
    }
}