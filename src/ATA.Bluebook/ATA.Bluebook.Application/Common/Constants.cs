namespace ATA.Application.Common
{
    public static class ClaimConstants
    {
        public static readonly string UserRole = "Role";
        public static readonly string TenantId = "Tenant";
        public static readonly string Permission = "Permission";
        public static readonly string UserId = "UserId";
    }

    public static class Permissions
    {
        public static class UserRoleManagement
        {
            public const string CanView = "UserRoleManagement.canView";
            public const string CanCreate = "UserRoleManagement.canCreate";
            public const string CanEdit = "UserRoleManagement.canEdit";
            public const string CanDelete = "UserRoleManagement.canDelete";
        }

        public static class UserManagement
        {
            public const string CanView = "UserManagement.canView";
            public const string CanCreate = "UserManagement.canCreate";
            public const string CanEdit = "UserManagement.canEdit";
            public const string CanDelete = "UserManagement.canDelete";

            public static class SubAdminManagement
            {
                public const string CanView = "UserManagement.SubAdminManagement.canView";
                public const string CanCreate = "UserManagement.SubAdminManagement.canCreate";
                public const string CanEdit = "UserManagement.SubAdminManagement.canEdit";
                public const string CanDelete = "UserManagement.SubAdminManagement.canDelete";
            }

            public static class EmployeeManagement
            {
                public const string CanView = "UserManagement.EmployeeManagement.canView";
                public const string CanCreate = "UserManagement.EmployeeManagement.canCreate";
                public const string CanEdit = "UserManagement.EmployeeManagement.canEdit";
                public const string CanDelete = "UserManagement.EmployeeManagement.canDelete";
            }
        }

        public static class Jobs
        {
            public const string CanView = "Jobs.canView";
            public const string CanCreate = "Jobs.canCreate";
            public const string CanEdit = "Jobs.canEdit";
            public const string CanDelete = "Jobs.canDelete";

            public static class List
            {
                public const string CanView = "Jobs.List.canView";
                public const string CanCreate = "Jobs.List.canCreate";
                public const string CanEdit = "Jobs.List.canEdit";
                public const string CanDelete = "Jobs.List.canDelete";
            }

            public static class MailCodes
            {
                public const string CanView = "Jobs.MailCodes.canView";
                public const string CanCreate = "Jobs.MailCodes.canCreate";
                public const string CanEdit = "Jobs.MailCodes.canEdit";
                public const string CanDelete = "Jobs.MailCodes.canDelete";
            }
        }
    }

}
