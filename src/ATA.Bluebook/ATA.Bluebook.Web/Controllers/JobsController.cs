using ATA.Bluebook.Web.Models;
using ATA.Bluebook.Web.Models.Jobs;
using ATA.Bluebook.Web.Models.User;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using ATA.Bluebook.Web.Common.Constants;

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
                        FormName = "Forms/_JobEventsForm",
                    },
                    new StepperModel {
                        Label = "Job Files",
                        FormName = "Forms/_JobFilesForm"
                    }
                ],
                PageModel = new JobFormPageModel()
            };
            return View(model);
        }

        public LoadResult GetJobTypes(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(JobsConstants.JobTypes, loadOptions);
        }

        public LoadResult GetPackageSizes(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(JobsConstants.PackageSizes, loadOptions);
        }

        public LoadResult GetIssues(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(JobsConstants.JobIssues, loadOptions);
        }

        public LoadResult GetCopywriter(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(JobsConstants.Copywriters, loadOptions);
        }

        public LoadResult GetCoordinator(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(JobsConstants.Coordinators, loadOptions);
        }

    }
}
