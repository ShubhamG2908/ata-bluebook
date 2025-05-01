
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
    public enum ContractType
    {
        DirectBill,
        NoRisk
    }
    public static class EnumHelper
    {
        public static List<object> GetEnumList(Type enumType)
        {
            return Enum.GetValues(enumType)
                       .Cast<Enum>()
                       .Select(e => new { Value = Convert.ToInt32(e), Text = e.ToString() })
                       .ToList<object>();
        }
    }
}
