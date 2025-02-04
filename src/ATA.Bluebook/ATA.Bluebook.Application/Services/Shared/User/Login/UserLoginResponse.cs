namespace ATA.Application.Services.Shared.User.Login
{
    public class UserLoginResponse
    {
        public Guid UserId { get; set; }
        public Guid TenantId { get; set; }
        public string Role { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Permission { get; set; } = default!;
        public string Username { get; set; } = default!;
        public Guid CookieTokenId { get; set; }
        public bool IsMigratedUser { get; set; }
        public bool IsInvitationAccepted { get; set; }
    }
}
