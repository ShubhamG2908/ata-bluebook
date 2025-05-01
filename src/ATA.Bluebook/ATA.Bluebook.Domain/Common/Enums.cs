
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
    public enum Status
    {
        New,
        InProgress,
        Done
    }
    public enum ProjectType
    {
        New,
        InProgress,
        Done
    }
    public enum ProgramType
    {
        New,
        InProgress,
        Done
    }
    public enum ContactType
    {
        New,
        InProgress,
        Done
    }
}
