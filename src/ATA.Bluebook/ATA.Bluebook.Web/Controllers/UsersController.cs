using ATA.Bluebook.Web.Models;
using ATA.Bluebook.Web.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View(Stepper());
        }

        #region Private Methods
        private static StepperPageModel Stepper() =>
            new()
            {
                StepperId = "UserFormStepper",
                Steps = [
                    new StepperModel {
                        Label = "Select user type",
                        FormName = "Forms/_UserTypeForm",
                    },
                    new StepperModel {
                        Label = "Personal Details",
                        FormName = "Forms/_UserPersonalDetails"
                    },
                    new StepperModel {
                        Label = "Account Details",
                        FormName = "Forms/_UserAccountDetails"
                    },
                    new StepperModel {
                        Label = "Done",
                        FormName = "Forms/_UserFormDone"
                    }
                ],
                PageModel = new UserFormPageModel()
            };
        #endregion
    }
}
