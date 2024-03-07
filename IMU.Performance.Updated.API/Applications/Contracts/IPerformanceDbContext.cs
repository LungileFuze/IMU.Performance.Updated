using IMU.Performance.Updated.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IMU.Performance.Updated.API.Applications.Contracts
{
    public interface IPerformanceDbContext
    {
        public DbSet<Agreement> Agreements {get; }

        public DbSet<KeyPerformanceArea> KeyPerformanceAreas { get; }

        public DbSet<KeyPerformanceIndicator> KeyPerformanceIndicators { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
