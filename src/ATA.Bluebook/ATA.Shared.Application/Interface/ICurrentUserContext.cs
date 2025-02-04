namespace ATA.Shared.Application.Interface
{
    public interface ICurrentUserContext
    {
        Guid TokenId { get; }
        Guid UserId { get; }
        Guid EmailAddress { get; }
        Guid TenantId { get; }
        string PolicyPermission { get; }
        bool HasValidPermission(string permissionType, string moduleName);
    }
}
