using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Areas.Bluebook.Controllers
{
    public class UserRoleManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
