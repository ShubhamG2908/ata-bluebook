
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
    public static class EnumHelper
    {
        public static List<object> GetEnumList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<T>()
                       .Select(e => new { Value = Convert.ToInt32(e), Text = e.ToString() })
                       .ToList<object>();
        }
    }
}
