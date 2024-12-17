using ATA.Bluebook.Web.Common.Constants;
using ATA.Bluebook.Web.Models.User;
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
        public UserType UserType { get; set; }

        public UserAccountDetailVM() { }

        public UserAccountDetailVM(UserType userType)
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
