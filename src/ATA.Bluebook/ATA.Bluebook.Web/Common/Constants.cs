namespace ATA.Web.Common
{
    public static class RegexConstants
    {
        public const string Email = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
    }

    public static class AlertTypes
    {
        public const string Success = "alert-success";
        public const string Info = "alert-primary";
        public const string Warning = "alert-warning";
        public const string Danger = "alert-danger";
    }
}
