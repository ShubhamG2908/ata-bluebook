using System.Text.RegularExpressions;

namespace ATA.Bluebook.Web.Common.Constants
{
    public class RegexConstants
    {
        public const string Email = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
        public const string PositiveNumber = "^[0-9]*$";
        public const string FloatingPositiveNumber = "^(0|[1-9]\\d*)(\\.\\d+)?$";
    }
}
