using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class TenantMasterEntityConfiguration : IEntityTypeConfiguration<TenantMasterEntity>
    {
        public void Configure(EntityTypeBuilder<TenantMasterEntity> builder)
        {
            builder.ToTable("TenantMaster", DbSchema.Shared).HasIndex(x => x.Name);

            builder.HasMany(t => t.TenantConfigs).WithOne(tc => tc.Tenant).HasForeignKey(tc => tc.TenantId);

            builder.HasMany(t => t.Users).WithOne(u => u.Tenant).HasForeignKey(u => u.TenantId);
            
            builder.HasMany(t=> t.RolePolicies).WithOne(rp => rp.Tenant).HasForeignKey(rp => rp.TenantId);
        }
    }  
}
