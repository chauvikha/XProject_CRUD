using Microsoft.EntityFrameworkCore;
using XProject.Contract.Repository.Models;

namespace XProject.Repository.Infrastructure
{
    public sealed partial class AppDbContext
    {
        public DbSet<WorkingTime> WorkingTimes { get; set; }
        public DbSet<cemetary> cemetaries { get; set; }


    }
}