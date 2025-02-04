using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class SystemAuditHistoryEntityConfiguration : IEntityTypeConfiguration<SystemAuditHistoryEntity>
    {
        public void Configure(EntityTypeBuilder<SystemAuditHistoryEntity> builder)
        {
            builder.ToTable("SystemAuditHistory", DbSchema.Shared);
        }
    }
}
