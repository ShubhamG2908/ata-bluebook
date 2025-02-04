using System.ComponentModel.DataAnnotations;

namespace ATA.Web.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        public bool RememberMe { get; set; } = false;
    }
}
