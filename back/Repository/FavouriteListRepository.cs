using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.FavouriteList;
using back.Interfaces;
using back.Models;

namespace back.Repository
{
    public class FavouriteListRepository : IFavouriteListRepository
    {
        public Task<FavouriteList> CreateAsync(FavouriteList favouriteListModel)
        {
            throw new NotImplementedException();
        }

        public Task<FavouriteList?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FavouriteList>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FavouriteList?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FavouriteList?> UpdateAsync(int id, UpdateFavouriteListDto favouriteListDto)
        {
            throw new NotImplementedException();
        }
    }
}