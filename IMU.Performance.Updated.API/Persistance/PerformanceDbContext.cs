using IMU.Performance.Updated.API.Applications.Contracts;
using IMU.Performance.Updated.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IMU.Performance.Updated.API.Persistance
{
    public class PerformanceDbContext : DbContext, IPerformanceDbContext
    {
        public PerformanceDbContext(DbContextOptions<PerformanceDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PerformanceDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Agreement> Agreements => Set<Agreement>();

        public DbSet<KeyPerformanceArea> KeyPerformanceAreas => Set<KeyPerformanceArea>();

        public DbSet<KeyPerformanceIndicator> KeyPerformanceIndicators => Set<KeyPerformanceIndicator>();
    }
}
