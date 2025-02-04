using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class RoleEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = default!;
        public string AllowedModule { get; set; } = default!;

        public virtual ICollection<RolePolicyEntity> RolePolices { get; set; } = new List<RolePolicyEntity>();

        public virtual UserMasterEntity User { get; set; } = default!;
    }
}
