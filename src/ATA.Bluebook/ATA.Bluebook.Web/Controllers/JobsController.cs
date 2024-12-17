using ATA.Bluebook.Web.Models;
using ATA.Bluebook.Web.Models.Jobs;
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

        public IActionResult Create()
        {
            var model = new StepperPageModel
            {
                StepperId = "JobFormsStepper",
                Steps = [
                    new StepperModel {
                        Label = "Job Details",
                        FormName = "Forms/_JobDetailsForm",
                    },
                    new StepperModel {
                        Label = "Job Events",
                        FormName = "Forms/PassForm",
                    },
                    new StepperModel {
                        Label = "Job Files",
                        FormName = "Forms/FormSubmitted"
                    }
                ],
                PageModel = new JobFormPageModel()
            };
            return View(model);
        }
    }
}
