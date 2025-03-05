using ATA.Web.Common;

using System.ComponentModel.DataAnnotations;

namespace ATA.Web.Models
{
    public class MigratedUserProfileUpdateModel
    {
        [Required]
        [RegularExpression(RegexConstants.Email, ErrorMessage = "Email is invalid")]
        public string Email { get; set; } = default!;

        [Required]
        public string Username { get; set; } = default!;

        [Required]
        public string Fullname { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = default!;
    }
}
