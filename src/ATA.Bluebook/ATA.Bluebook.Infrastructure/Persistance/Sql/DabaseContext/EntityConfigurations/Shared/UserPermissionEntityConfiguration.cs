using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class UserPermissionEntityConfiguration : IEntityTypeConfiguration<UserPermissionEntity>
    {
        public void Configure(EntityTypeBuilder<UserPermissionEntity> builder)
        {
            builder.ToTable("UserPermission", DbSchema.Shared);
        }
    }
}
