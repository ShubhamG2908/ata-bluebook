using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class ClientManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
