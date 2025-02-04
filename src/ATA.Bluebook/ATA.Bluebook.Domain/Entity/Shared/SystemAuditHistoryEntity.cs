using ATA.Domain.Common;

namespace ATA.Domain.Entity.Shared
{
    public class SystemAuditHistoryEntity : BaseEntity
    {
        public AuditType AuditType { get; set; }
        public Guid UserId { get; set; } 
        public string Histroy { get; set; } = default!;
        public virtual UserMasterEntity User { get; set; } = default!;
    }
}
