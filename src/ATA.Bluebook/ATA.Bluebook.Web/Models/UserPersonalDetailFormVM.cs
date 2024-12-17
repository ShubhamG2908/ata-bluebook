using System.ComponentModel.DataAnnotations;
using ATA.Bluebook.Web.Common.Constants;

namespace ATA.Bluebook.Web.Models
{
    public record UserPersonalDetailFormVM
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

}
