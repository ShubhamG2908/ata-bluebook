using ATA.Application.Services.Shared.User.Login;
using ATA.Web.Common.Constants;
using ATA.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

using System.Data;

using System.Security.Claims;
using System.Text.RegularExpressions;
using ATA.Application.Services.Shared.User.UpdateMigrateUserProfile;
using ATA.Application.Common;

namespace ATA.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(nameof(Index), model);

            var userLoginData = await _mediator.Send(new UserLoginCommand(model.Username, model.Password));

            if (userLoginData == null)
            {
                ModelState.AddModelError("Username", "Invalid Username or Password");
                return View(nameof(Index), model);
            }

            // User is migrated and using the old data. Redirect the user to update this details.
            if (userLoginData.IsMigratedUser && !Regex.IsMatch(userLoginData.Username, RegexConstants.Email))
            {
                // Temporary Save the userLoginData in session to use it later
                HttpContext.Session.SetString(ClaimTypes.NameIdentifier, userLoginData.CookieTokenId.ToString());
                HttpContext.Session.SetString(ClaimConstants.UserId, userLoginData.UserId.ToString());

                // Redirect the user
                return View("MigratedUserProfileUpdate", new MigratedUserProfileUpdateModel
                {
                    Email = userLoginData.Email,
                    Username = userLoginData.Username,
                    Fullname = userLoginData.Username
                });
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userLoginData.CookieTokenId.ToString()),
                new Claim(ClaimTypes.Name, userLoginData.Username),
                new Claim(ClaimTypes.Email, userLoginData.Email),
                new Claim(ClaimConstants.TenantId, userLoginData.TenantId.ToString()),
                new Claim(ClaimConstants.UserId, userLoginData.UserId.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = model.RememberMe,
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

            HttpContext.Session.SetString(ClaimConstants.UserRole, userLoginData.Role);
            HttpContext.Session.SetString(ClaimConstants.Permission, userLoginData.Permission);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMigratedUserProfile(MigratedUserProfileUpdateModel model)
        {
            if (!ModelState.IsValid)
                return View("MigratedUserProfileUpdate", model);

            var userSecuerityId = Guid.Parse(HttpContext.Session.GetString(ClaimTypes.NameIdentifier) ?? Guid.Empty.ToString());
            var userId = Guid.Parse(HttpContext.Session.GetString(ClaimConstants.UserId) ?? Guid.Empty.ToString());

            if (userSecuerityId == Guid.Empty || userId == Guid.Empty)
            {
                ViewBag.ErrorMessage = "Oops! Please try to login again and then update the profile.";
                return View("MigratedUserProfileUpdate", model);
            }

            var resp = await _mediator.Send(new UpdateMigratedUserProfileCommand(userSecuerityId,
                                                                                 userId,
                                                                                 model.Email,
                                                                                 model.Username,
                                                                                 model.Fullname,
                                                                                 model.Password));

            if (!resp)
            {
                ViewBag.ErrorMessage = "Oops! Either user not found or something went wrong. Please try again.";
                return View("MigratedUserProfileUpdate", model);
            }

            HttpContext.Session.Remove(ClaimTypes.NameIdentifier);
            HttpContext.Session.Remove(ClaimConstants.UserId);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgetPassword()
        {
            return View(new ForgotPassword());
        }

        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordModel model)
        {
            if (!ModelState.IsValid)
                return View(nameof(Index), model);

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
                return View(nameof(Index), model);

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
