using System.ComponentModel.DataAnnotations;

namespace ATA.Web.Models
{
    public class ForgetPasswordModel
    {
        [Required, Display(Name = "Email Address")]
        public string Username { get; set; } = default!;
    }

}
