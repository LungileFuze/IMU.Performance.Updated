using IMU.Performance.Updated.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IMU.Performance.Updated.API.Persistance.Configurations
{
    public class KeyPerformanceIndicatorConfiguration : IEntityTypeConfiguration<KeyPerformanceIndicator>
    {
        public void Configure(EntityTypeBuilder<KeyPerformanceIndicator> builder)
        {
            builder.ToTable("KeyPerformanceIndicator");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("bigint").IsRequired().UseIdentityColumn(1, 1);
            builder.Property(p => p.KeyPerformanceAreaId).HasColumnType("bigint").IsRequired();
            builder.HasOne(p => p.KeyPerformanceArea).WithMany(a => a.KeyPerformanceIndicators).HasForeignKey(p => p.KeyPerformanceAreaId);
            builder.Property(p => p.Description).HasColumnType("nvarchar(2000)").IsRequired();
            builder.Property(p => p.Weighting).HasColumnType("int").IsRequired();
            builder.Property(p => p.MidtermScore).HasColumnType("int");
            builder.Property(p => p.MidtermWeightedScore).HasColumnType("decimal(3,2");
            builder.Property(p => p.FinalScore).HasColumnType("int");
            builder.Property(p => p.FinalWeightedScore).HasColumnType("decimal(3,2");
            builder.Property(p => p.DateCreated).HasColumnType("datetime").IsRequired();
        }
    }
}
