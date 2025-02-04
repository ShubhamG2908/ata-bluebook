namespace ATA.Application.Interface
{
    public interface ICurrentUserContext
    {
        Guid TokenId { get; }
        Guid UserId { get; }
        string EmailAddress { get; }
        string Role { get; }
        bool HasValidPermission(string permissionName);
    }
}
