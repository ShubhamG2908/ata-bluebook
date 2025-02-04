using System.ComponentModel.DataAnnotations;
using ATA.Web.Common.Constants;

namespace ATA.Web.Models
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

        string? WhiteMailCode,

        bool IsActive
    );

}
