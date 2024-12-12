using ATA.Bluebook.Web.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models
{
    public record UserAccountDetailFormVM
    (
        [Required]
        [RegularExpression(RegexConstants.Email, ErrorMessage = "Email is invalid")]
        string Email,
        string UserName,
        string Password,
        string FullName,
        int? ClientId,
        List<int>? ClientList,
        string? AgencyId
    );

    public class UserAccountDetailVM
    {
        public UserAccountDetailFormVM? form { get; set; }
        public int UserType { get; set; }

        public UserAccountDetailVM() { }

        public UserAccountDetailVM(int userType)
        {
            UserType = userType;
        }
    }

    public class ClientSelectionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
