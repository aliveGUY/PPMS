using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.ModeratorList;
using back.Interfaces;
using back.Models;

namespace back.Repository
{
    public class ModeratorListRepository : IModeratorListRepository
    {
        public Task<ModeratorList> CreateAsync(ModeratorList ModeratorListModel)
        {
            throw new NotImplementedException();
        }

        public Task<ModeratorList?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ModeratorList>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ModeratorList?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ModeratorList?> UpdateAsync(int id, UpdateModeratorListDto ModeratorListDto)
        {
            throw new NotImplementedException();
        }
    }
}