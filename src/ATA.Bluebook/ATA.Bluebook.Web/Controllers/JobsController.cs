using ATA.Bluebook.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            var model = new StepperPageModel
            {
                StepperId = "MyStepperForm",
                Steps = [
                    new StepperModel {
                        Label = "Email",
                        FormName = "Forms/UserForm",
                    },
                    new StepperModel {
                        Label = "Password",
                        FormName = "Forms/PassForm",
                    },
                    new StepperModel {
                        Label = "Done",
                        FormName = "Forms/FormSubmitted"
                    }
                ]
            };
            return View(model);
        }
    }
}
