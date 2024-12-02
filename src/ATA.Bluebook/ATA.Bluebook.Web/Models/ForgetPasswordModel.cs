using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models
{
	public record ForgetPasswordModel([Required, Display(Name = "Email Address")] string Username);

}
