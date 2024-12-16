using ATA.Bluebook.Web.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models.User
{
    public class UserFormPageModel
    {
        public UserPersonalDetailForm PersonalDetailForm { get; set; } = default!;
        public UserAccountDetailForm AccountDetailForm { get; set; } = default!;
        public UserTypeDetailForm UserTypeForm { get; set; } = new UserTypeDetailForm();
    }

    public enum UserType
    {
        Client,
        Agency
    }

    public class ClientSelectionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class UserTypeDetailForm
    {
        [Required]
        public UserType UserType { get; set; } = UserType.Client;
    };

    public class CommonUserFormSelectonModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public record UserPersonalDetailForm
    (
        [Required]
        string Name,
        [Required]
        string Address,
        [Required]
        string City,
        [Required]
        int Zip,
        [Required]
        string State,
        [Required]
        string Contact,
        [Required]
        [RegularExpression(RegexConstants.Email, ErrorMessage = "Email is invalid")]
        string Email,
        string? ClosedCode,
        string? CloseDays,
        string? WhiteMailCode,
        bool IsActive
    );

    public record UserAccountDetailForm
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
}
