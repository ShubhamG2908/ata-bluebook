using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class RolePolicyEntityConfiguration : IEntityTypeConfiguration<RolePolicyEntity>
    {
        public void Configure(EntityTypeBuilder<RolePolicyEntity> builder)
        {
            builder.ToTable("RolePolicy", DbSchema.Shared);

            builder.Property(e => e.Id)
              .HasValueGenerator<SequentialGuidValueGenerator>();
        }
    }
}
