using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.FavouriteList;
using back.Models;

namespace back.Interfaces
{
    public interface IFavouriteListRepository
    {
        Task<List<FavouriteList>> GetAllAsync();
        Task<FavouriteList?> GetByIdAsync(int id);
        Task<FavouriteList> CreateAsync(FavouriteList favouriteListModel);
        Task<FavouriteList?> UpdateAsync(int id, UpdateFavouriteListDto favouriteListDto);
        Task<FavouriteList?> DeleteAsync(int id);
    }
}