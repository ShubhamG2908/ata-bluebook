using System.ComponentModel.DataAnnotations;

namespace ATA.Domain.Entity.Shared
{
    public class UserSeceurityEntity : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Username { get; set; } = default!;

        [MaxLength(150)]
        public string Password { get; set; } = default!;

        public bool IsInvitationAccepted { get; set; } 

        public bool IsBlocked { get; set; } 

        public bool HasPasswordChanged { get; set; } 

        public DateTime LastPasswordChangedOn { get; set; }

        public virtual UserMasterEntity User { get; set; } = default!;
    }
}
