using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
