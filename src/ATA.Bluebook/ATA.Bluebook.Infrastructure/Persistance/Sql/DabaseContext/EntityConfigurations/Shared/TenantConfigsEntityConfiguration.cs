using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class TenantConfigsEntityConfiguration : IEntityTypeConfiguration<TenantConfigsEntity>
    {
        public void Configure(EntityTypeBuilder<TenantConfigsEntity> builder)
        {
            builder.ToTable("TenantConfigs", DbSchema.Shared);
        }
    }
}
