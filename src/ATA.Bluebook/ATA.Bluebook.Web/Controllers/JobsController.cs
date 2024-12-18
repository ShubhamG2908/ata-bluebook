using ATA.Bluebook.Web.Models;
using ATA.Bluebook.Web.Models.Jobs;
using ATA.Bluebook.Web.Models.User;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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
            List<CommonUserFormSelectonModel> list = new List<CommonUserFormSelectonModel>();
            list.Add(new CommonUserFormSelectonModel { Id = 1, Name = "Monthly Giving" });
            list.Add(new CommonUserFormSelectonModel { Id = 2, Name = "House" });
            list.Add(new CommonUserFormSelectonModel { Id = 3, Name = "High $ House" });
            list.Add(new CommonUserFormSelectonModel { Id = 4, Name = "Prospect" });
            list.Add(new CommonUserFormSelectonModel { Id = 5, Name = "Master File" });
            list.Add(new CommonUserFormSelectonModel { Id = 6, Name = "Modeled Names" });
            list.Add(new CommonUserFormSelectonModel { Id = 7, Name = "Newsletter" });
            list.Add(new CommonUserFormSelectonModel { Id = 8, Name = "Reactive" });
            list.Add(new CommonUserFormSelectonModel { Id = 9, Name = "Conversions" });
            list.Add(new CommonUserFormSelectonModel { Id = 10, Name = "Thank You" });
            list.Add(new CommonUserFormSelectonModel { Id = 11, Name = "Creative Fee - House" });
            list.Add(new CommonUserFormSelectonModel { Id = 12, Name = "Creative Fee - Prospect" });
            list.Add(new CommonUserFormSelectonModel { Id = 13, Name = "Closed Codes & White Mail" });
            list.Add(new CommonUserFormSelectonModel { Id = 14, Name = "Sweeps" });
            list.Add(new CommonUserFormSelectonModel { Id = 15, Name = "Telemarketing" });
            list.Add(new CommonUserFormSelectonModel { Id = 16, Name = "Email - House" });
            list.Add(new CommonUserFormSelectonModel { Id = 17, Name = "Email - Prospect" });
            list.Add(new CommonUserFormSelectonModel { Id = 18, Name = "ATA Purchase Names - House" });
            list.Add(new CommonUserFormSelectonModel { Id = 19, Name = "ATA Purchase Names - Prospect" });
            list.Add(new CommonUserFormSelectonModel { Id = 20, Name = "Non-Donor" });
            return DataSourceLoader.Load(list, loadOptions);
        }

        public LoadResult GetPackageSizes(DataSourceLoadOptions loadOptions)
        {
            List<CommonUserFormSelectonModel> list = new List<CommonUserFormSelectonModel>();
            list.Add(new CommonUserFormSelectonModel { Id = 1, Name = "A: 10 x 13" });
            list.Add(new CommonUserFormSelectonModel { Id = 2, Name = "B: 9 x 12" });
            list.Add(new CommonUserFormSelectonModel { Id = 3, Name = "C: 6 x 9" });
            list.Add(new CommonUserFormSelectonModel { Id = 4, Name = "D: #14" });
            list.Add(new CommonUserFormSelectonModel { Id = 5, Name = "E: #12" });
            return DataSourceLoader.Load(list, loadOptions);
        }

        public LoadResult GetIssues(DataSourceLoadOptions loadOptions)
        {
            List<CommonUserFormSelectonModel> list = new List<CommonUserFormSelectonModel>();
            list.Add(new CommonUserFormSelectonModel { Id = 1, Name = "A0: Anti Obama" });
            list.Add(new CommonUserFormSelectonModel { Id = 2, Name = "A1: Drug Free Kids" });
            list.Add(new CommonUserFormSelectonModel { Id = 3, Name = "A2: Domestic Child Aid" });
            list.Add(new CommonUserFormSelectonModel { Id = 4, Name = "A3: International Child Aid" });
            list.Add(new CommonUserFormSelectonModel { Id = 5, Name = "A4: Service Dogs" });
            list.Add(new CommonUserFormSelectonModel { Id = 6, Name = "B1: General Defense/Terrorism" });
            list.Add(new CommonUserFormSelectonModel { Id = 7, Name = "B2: Homeland Security" });
            list.Add(new CommonUserFormSelectonModel { Id = 8, Name = "B3: Strong National Defense" });
            list.Add(new CommonUserFormSelectonModel { Id = 9, Name = "B4: Second Amendment Rights" });
            list.Add(new CommonUserFormSelectonModel { Id = 10, Name = "B5: Law Enforcement Defense" });
            list.Add(new CommonUserFormSelectonModel { Id = 11, Name = "C1: English Only" });
            list.Add(new CommonUserFormSelectonModel { Id = 12, Name = "C2: Catholic General" });
            list.Add(new CommonUserFormSelectonModel { Id = 13, Name = "C7: Conservative Senate Campaign" });
            return DataSourceLoader.Load(list, loadOptions);
        }

        public LoadResult GetCopywriter(DataSourceLoadOptions loadOptions)
        {
            List<CommonUserFormSelectonModel> list = new List<CommonUserFormSelectonModel>();
            list.Add(new CommonUserFormSelectonModel { Id = 1, Name = "Larry Clark" });
            list.Add(new CommonUserFormSelectonModel { Id = 2, Name = "Christopher Hiller" });
            list.Add(new CommonUserFormSelectonModel { Id = 3, Name = "Betty Thompson" });
            list.Add(new CommonUserFormSelectonModel { Id = 4, Name = "William Lawson" });
            list.Add(new CommonUserFormSelectonModel { Id = 5, Name = "Andrew Allen" });
            list.Add(new CommonUserFormSelectonModel { Id = 6, Name = "Christopher Jensen" });
            return DataSourceLoader.Load(list, loadOptions);
        }

        public LoadResult GetCoordinator(DataSourceLoadOptions loadOptions)
        {
            List<CommonUserFormSelectonModel> list = new List<CommonUserFormSelectonModel>();
            list.Add(new CommonUserFormSelectonModel { Id = 1, Name = "Stuart Oneil" });
            list.Add(new CommonUserFormSelectonModel { Id = 2, Name = "Brandon Bortz" });
            list.Add(new CommonUserFormSelectonModel { Id = 3, Name = "Vickie Plummer" });
            list.Add(new CommonUserFormSelectonModel { Id = 4, Name = "Tommy Eaddy" });
            list.Add(new CommonUserFormSelectonModel { Id = 5, Name = "Ray Williams" });
            list.Add(new CommonUserFormSelectonModel { Id = 6, Name = "Delia Bailey" });
            return DataSourceLoader.Load(list, loadOptions);
        }

    }
}
