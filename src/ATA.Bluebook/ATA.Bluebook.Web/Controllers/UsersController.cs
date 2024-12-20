using ATA.Bluebook.Web.Models;
using ATA.Bluebook.Web.Models.User;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        public LoadResult UserTypeList(DataSourceLoadOptions loadOptions)
        {
            List<CommonUserFormSelectonModel> list = new List<CommonUserFormSelectonModel>();
            var userTypeIds = Enum.GetValues(typeof(UserType));
            foreach (var item in userTypeIds)
            {
                list.Add(new CommonUserFormSelectonModel { Id = Convert.ToInt32(item), Name = Enum.GetName(typeof(UserType), item) ?? "" });
            }
            return DataSourceLoader.Load(list, loadOptions);
        }

        [HttpPost]
        public JsonResult CreateUser(UserFormPageModel formPageModel)
        {
            Console.WriteLine(formPageModel);

            // Create User Logic Here
            
            return Json(formPageModel);
        }

        #region Private Methods
        private static StepperPageModel Stepper() =>
            new()
            {
                StepperId = "UserFormStepper",
                Steps = [
                    new StepperModel {
                        Label = "Select User Type",
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
                        Label = "Submit",
                        FormName = "Forms/_UserFormDone"
                    }
                ],
                PageModel = new UserFormPageModel()
            };
        #endregion
    }
}
