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
        Task<List<Playground>> SearchByAddressAsync(string address);
        Task<List<Playground>> SearchByCityAsync(string city);
        Task<List<Playground>> SearchByProvinceAsync(string province);
        Task<List<Playground>> SearchByCountryAsync(string country);
        Task<Playground?> GetByIdAsync(int id);
        Task<Playground> CreateAsync(Playground playgroundModel);
        Task<Playground?> UpdateAsync(int id, UpdatePlaygroundDto playgroundDto);
        Task<Playground?> DeleteAsync(int id);
    }
}