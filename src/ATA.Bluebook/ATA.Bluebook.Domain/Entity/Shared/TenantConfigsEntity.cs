using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class TenantConfigsEntity : BaseEntity, ITenantEntity
    {
        public Guid TenantId { get; set; }

        [MaxLength(50)]
        public string ConfigKey { get; set; } = default!;

        [MaxLength(1000)]
        public string ConfigValue { get; set; } = default! ;

        [MaxLength(500)]
        public string Description { get; set; } = default!;

        public virtual TenantMasterEntity Tenant { get; set; } = default!;
    }
}
