using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
