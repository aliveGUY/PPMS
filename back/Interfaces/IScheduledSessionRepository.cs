using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.ScheduledSession;
using back.Models;

namespace back.Interfaces
{
    public interface IScheduledSessionRepository
    {
        Task<List<ScheduledSession>> GetAllAsync();
        Task<ScheduledSession?> GetByIdAsync(int id);
        Task<ScheduledSession> CreateAsync(ScheduledSession scheScheduledSessionModel);
        Task<ScheduledSession?> UpdateAsync(int id, UpdateScheduledSessionDto scheScheduledSessionDto);
        Task<ScheduledSession?> DeleteAsync(int id);
    }
}