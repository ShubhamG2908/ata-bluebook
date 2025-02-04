using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class RolePolicyEntity : BaseEntity, ITenantEntity
    {
        public Guid RoleId { get; set; }

        [MaxLength(30)]
        public string Name { get; set; } = default!;

        public string DefaultPermission { get; set; } = default!;

        public Guid TenantId { get; set; }

        public virtual TenantMasterEntity Tenant { get; set; } = default!;

        public virtual RoleEntity Role { get; set; } = default!;
    }
}
