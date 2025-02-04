using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class AdressEntityConfiguration : IEntityTypeConfiguration<AdressEntity>
    {
        public void Configure(EntityTypeBuilder<AdressEntity> builder)
        {
            builder.ToTable("Adress", DbSchema.Shared);
        }
    }
}
