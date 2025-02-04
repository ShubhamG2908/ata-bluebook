using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class UserMasterEntity : BaseEntity, ITenantEntity
    {
        [MaxLength(10)]
        public string UserCode { get; set; } = default!;

        [MaxLength(30)]
        public string Fullname { get; set; } = default!;

        [MaxLength(100)]
        public string Email { get; set; } = default!;

        [MaxLength(15)]
        public string? ContactNumber { get; set; }

        [MaxLength(15)]
        public string? FaxNumber { get; set; }

        [MaxLength(8)]
        public string? Extension { get; set; }

        public bool IsMigratedUser { get; set; }

        public Guid TenantId { get; set; }

        public Guid? AddressId { get; set; }

        public Guid? RoleId { get; set; }

        public Guid? UserPermissionId { get; set; }

        public virtual TenantMasterEntity Tenant { get; set; } = default!;

        public virtual AdressEntity? Address { get; set; } = default!;

        public virtual RoleEntity Role { get; set; } = default!;

        public virtual UserPermissionEntity UserPermission { get; set; } = default!;

        public virtual ICollection<UserApplicationSettingsEntity> UserApplicationSettings { get; set; } = new List<UserApplicationSettingsEntity>();

        public virtual ICollection<SystemAuditHistoryEntity> systemAuditHistories { get; set; } = new List<SystemAuditHistoryEntity>();

        public virtual UserSeceurityEntity UserSeceurity { get; set; } = default!;
    }
}
