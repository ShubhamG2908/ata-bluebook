using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class UserRoleManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
