using ATA.Bluebook.Web.Models;

using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View(new LoginModelRecord(string.Empty, string.Empty));
        }

        [HttpPost]
        public IActionResult Login(LoginModelRecord model)
        {
            if (!ModelState.IsValid)
            {

                return View(nameof(Index), model);
            }
            else
            {
                if (string.Equals(model.Username, model.Password))
                {
                    HttpContext.Session.SetString("UserName", model.Username);
                    return RedirectToAction("Index", "Jobs");
                }
            }
            return Ok();
        }

        public IActionResult ForgetPassword()
        {
            return View(new ForgetPasswordModel(string.Empty));
        }

        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), model);
            }
            return RedirectToAction(nameof(ChangePassword));
        }

        public IActionResult ChangePassword()
        {
            return View(new ChangePasswordModel());
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), model);
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");
            return View(nameof(Index));
        }
    }
}
