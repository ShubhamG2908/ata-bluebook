using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.ToTable("Role", DbSchema.Shared)
                .HasIndex(x => x.Name);

            builder.HasMany(r => r.RolePolices).WithOne(rp => rp.Role).HasForeignKey(rp => rp.RoleId);
        }
    }
}
