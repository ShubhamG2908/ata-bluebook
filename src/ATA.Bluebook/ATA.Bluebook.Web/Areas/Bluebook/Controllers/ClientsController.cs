using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Areas.Bluebook.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
