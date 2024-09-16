using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back.Data
{
    public class ApplicationDBContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<FavouriteList> FavouriteList { get; set; }
        public DbSet<ModeratorList> ModeratorList { get; set; }
        public DbSet<Playground> Playground { get; set; }
        public DbSet<ScheduledSession> ScheduledSession { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Vote> Vote { get; set; }
        public DbSet<Voting> Voting { get; set; }
    }
}