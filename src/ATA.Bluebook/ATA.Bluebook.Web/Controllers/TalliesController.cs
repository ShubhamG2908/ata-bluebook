using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class TalliesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
