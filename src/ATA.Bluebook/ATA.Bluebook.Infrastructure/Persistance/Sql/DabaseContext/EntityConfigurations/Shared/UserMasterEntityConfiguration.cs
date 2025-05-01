using ATA.Domain.Entity.Shared;
using ATA.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Reflection.Emit;
using System.Xml;


namespace ATA.Infrastructure.Persistance.Sql.DabaseContext.EntityConfigurations.Shared
{
    public class UserMasterEntityConfiguration : IEntityTypeConfiguration<UserMasterEntity>
    {
        public void Configure(EntityTypeBuilder<UserMasterEntity> builder)
        {
            builder.ToTable("UserMaster", DbSchema.Shared);

            builder.Property(e => e.Id)
                 .HasValueGenerator<SequentialGuidValueGenerator>();

            builder.HasOne(u => u.Address)
                .WithOne(a => a.User)
                .HasForeignKey<UserMasterEntity>(u => u.AddressId);

            builder.HasOne(u => u.Role)
                .WithOne(r => r.User)
                .HasForeignKey<UserMasterEntity>(u => u.RoleId);

            builder.HasOne(u => u.UserPermission)
                .WithOne(up => up.User)
                .HasForeignKey<UserMasterEntity>(u => u.UserPermissionId);

            builder.HasMany(u => u.UserApplicationSettings)
                .WithOne(uas => uas.User)
                .HasForeignKey(uas => uas.UserId);

            builder.HasMany(u => u.systemAuditHistories)
                .WithOne(sah => sah.User)
                .HasForeignKey(sah => sah.UserId);

            builder.HasOne(u => u.UserSeceurity)
                .WithOne(us => us.User)
                .HasForeignKey<UserSeceurityEntity>(us => us.UserId);

            builder.HasIndex(u => u.UserCode).IsUnique();

            builder.HasIndex(u => u.Fullname);
        }
    }
}
