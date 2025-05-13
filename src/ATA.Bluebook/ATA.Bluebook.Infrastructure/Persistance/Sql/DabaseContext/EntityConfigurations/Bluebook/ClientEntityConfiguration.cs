using ATA.Domain.Entity.Bluebook;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Bluebook
{
    public class ClientEntityConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.ToTable("Client", DbSchema.Bluebook);

            builder.Property(e => e.Id)
                  .HasValueGenerator<SequentialGuidValueGenerator>();
        }
    }
}
