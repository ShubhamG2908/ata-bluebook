using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Users");
        }
        
        public IActionResult Users()
        {
            return View();
        }

        public IActionResult ListName()
        {
            return View();
        }

        public IActionResult QuickCostDataEntry()
        {
            return View();
        }
    }
}
