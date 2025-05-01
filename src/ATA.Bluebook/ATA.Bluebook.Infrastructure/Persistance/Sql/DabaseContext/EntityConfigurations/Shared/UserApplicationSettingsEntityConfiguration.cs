using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class UserApplicationSettingsEntityConfiguration : IEntityTypeConfiguration<UserApplicationSettingsEntity>
    {
        public void Configure(EntityTypeBuilder<UserApplicationSettingsEntity> builder)
        {
            builder.ToTable("UserApplicationSettings", DbSchema.Shared);

            builder.Property(e => e.Id)
              .HasValueGenerator<SequentialGuidValueGenerator>();
        }
    }
}
