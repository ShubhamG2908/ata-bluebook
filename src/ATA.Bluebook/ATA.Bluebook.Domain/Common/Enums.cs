
namespace ATA.Domain.Common
{
    enum UserRole
    {
        SuperAdmin,
        Admin,
        Employee,
        Client,
        Agency,
        Vendor
    }

    public enum AuditType
    {
        Create,
        Update,
        Delete
    }

    enum UserPermission
    {
        CanCreate,
        CanRead,
        CanUpdate,
        CanDelete
    }
}
