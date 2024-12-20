using ATA.Bluebook.Web.Models;
using ATA.Bluebook.Web.Models.Jobs;
using ATA.Bluebook.Web.Models.User;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using ATA.Bluebook.Web.Common.Constants;
using ATA.Bluebook.Web.Common.Helpers;

namespace ATA.Bluebook.Web.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(GetStepper(new JobFormPageModel()));
        }

        public IActionResult Edit()
        {
            var pageModel = new JobFormPageModel();
            pageModel.IsEditMode = true;

            pageModel.JobDetailsForm = new JobDetailsForm();
            pageModel.JobDetailsForm.JobName = "Job 1";

            return View(pageModel);
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

        [HttpGet]
        public IActionResult GetJobsData(DataSourceLoadOptions loadOptions)
        {
            return Ok(DummyDataHelper.GetDummyJobsData());
        }

        #region Private Methods
        private StepperPageModel GetStepper(JobFormPageModel model) =>
            new()
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
                PageModel = model
            };
        #endregion

    }
}
