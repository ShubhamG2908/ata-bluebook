namespace ATA.Domain.Entity.Shared
{
    public class UserPermissionEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Permission { get; set; } = default!;
        public virtual UserMasterEntity User { get; set; } = default!;
    }
}
