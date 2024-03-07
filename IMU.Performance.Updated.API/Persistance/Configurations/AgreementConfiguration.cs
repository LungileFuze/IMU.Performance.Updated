using IMU.Performance.Updated.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IMU.Performance.Updated.API.Persistance.Configurations
{
    public class AgreementConfiguration: IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder) 
        {
            builder.ToTable("Agreement");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("bigint").IsRequired().UseIdentityColumn(1, 1);
            builder.Property(p => p.FinancialYear).HasColumnType("nvarchar(9)").IsRequired();
            builder.Property(p => p.ManagerServiceNumber).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.ServiceNumber).HasColumnType("nvarchar(30)").IsRequired();
        }
    }
}
