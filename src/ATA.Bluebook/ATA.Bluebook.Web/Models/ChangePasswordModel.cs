using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models
{
	public record ChangePasswordModel
	{
		[Required]
		public string Passwrod { get; set; } = default!;

		[Required, Compare("Passwrod", ErrorMessage = "Passwords don't match.")]
		public string ConfirmPassword { get; set; } = default!;
	}
}
