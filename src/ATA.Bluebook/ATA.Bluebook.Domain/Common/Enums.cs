
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
        Active,
        InActive,
        Idle
    }
    public enum ProjectType
    {
        Charitable,
        Ideological
    }
    public enum ProgramType
    {
        Conventional,
        Sweeps
    }
    public enum ContractType
    {
        DirectBill,
        NoRisk
    }
    public static class EnumHelper
    {
        public static List<EnumItem> GetEnumList(Type enumType)
        {
            return Enum.GetValues(enumType)
                       .Cast<Enum>()
                       .Select(e => new EnumItem
                       {
                           Value = Convert.ToInt32(e),
                           Text = e.ToString()
                       })
                       .ToList();
        }

        public class EnumItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }
    }
}
