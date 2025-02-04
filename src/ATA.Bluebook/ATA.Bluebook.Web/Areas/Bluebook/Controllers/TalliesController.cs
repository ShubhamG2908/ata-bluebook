using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Areas.Bluebook.Controllers
{
    public class TalliesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
