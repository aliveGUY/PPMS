using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.ModeratorList;
using back.Models;

namespace back.Interfaces
{
    public interface IModeratorListRepository
    {
        Task<List<ModeratorList>> GetAllAsync();
        Task<ModeratorList?> GetByIdAsync(int id);
        Task<ModeratorList> CreateAsync(ModeratorList ModeratorListModel);
        Task<ModeratorList?> UpdateAsync(int id, UpdateModeratorListDto ModeratorListDto);
        Task<ModeratorList?> DeleteAsync(int id);
    }
}