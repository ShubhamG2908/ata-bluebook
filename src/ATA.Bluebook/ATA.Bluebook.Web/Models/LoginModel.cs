using System.ComponentModel.DataAnnotations;

namespace ATA.Bluebook.Web.Models
{
	public record LoginModelRecord(
		[Required]
		string Username,

		[Required]
		string Password
		);
}
