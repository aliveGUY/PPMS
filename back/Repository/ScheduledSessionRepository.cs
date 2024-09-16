using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.DTOs.ScheduledSession;
using back.Interfaces;
using back.Models;

namespace back.Properties
{
    public class ScheduledSessionRepository : IScheduledSessionRepository
    {
        public Task<ScheduledSession> CreateAsync(ScheduledSession scheScheduledSessionModel)
        {
            throw new NotImplementedException();
        }

        public Task<ScheduledSession?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ScheduledSession>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ScheduledSession?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ScheduledSession?> UpdateAsync(int id, UpdateScheduledSessionDto scheScheduledSessionDto)
        {
            throw new NotImplementedException();
        }
    }
}