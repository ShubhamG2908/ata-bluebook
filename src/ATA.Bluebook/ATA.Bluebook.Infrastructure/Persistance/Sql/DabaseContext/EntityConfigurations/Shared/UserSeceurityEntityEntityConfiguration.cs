using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class UserSeceurityEntityEntityConfiguration : IEntityTypeConfiguration<UserSeceurityEntity>
    {
        public void Configure(EntityTypeBuilder<UserSeceurityEntity> builder)
        {
            builder.ToTable("UserSeceurityEntity", DbSchema.Shared);

            builder.Property(e => e.Id)
                 .HasValueGenerator<SequentialGuidValueGenerator>();

            builder.HasIndex(u => u.Username).IsUnique();
        }
    }
}
