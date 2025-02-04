namespace ATA.Domain.Entity.Shared
{
    public class UserApplicationSettingsEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Settings { get; set; } = string.Empty;

        public virtual UserMasterEntity User { get; set; } = default!;
    }
}
