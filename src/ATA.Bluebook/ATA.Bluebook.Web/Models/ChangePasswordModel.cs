using System.ComponentModel.DataAnnotations;

namespace ATA.Web.Models
{
	public class ChangePasswordModel
	{
		[Required]
		public string Password { get; set; } = default!;

		[Required, Compare("Password", ErrorMessage = "Passwords don't match.")]
		public string ConfirmPassword { get; set; } = default!;
	}
}
