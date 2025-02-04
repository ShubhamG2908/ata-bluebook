using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class TenantMasterEntity : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; } = default!;    

        [MaxLength(10)]
        public string Code { get; set; } =  default!;

        public virtual ICollection<TenantConfigsEntity> TenantConfigs { get; set; } = new List<TenantConfigsEntity>();
        public virtual ICollection<UserMasterEntity> Users { get; set; } = new List<UserMasterEntity>();

        public virtual ICollection<RolePolicyEntity> RolePolicies { get; set; } = new List<RolePolicyEntity>();
    }
}
