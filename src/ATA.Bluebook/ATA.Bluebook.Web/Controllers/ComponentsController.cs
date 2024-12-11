using ATA.Bluebook.Web.Models;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Index()
        {
            return View(GetComponentTabList());
        }

        private List<ComponentTabModel> GetComponentTabList()
        {
            List<ComponentTabModel> componentTabs = new()
            {
                new ComponentTabModel(1, "Textbox"),
                new ComponentTabModel(2, "Selectbox"),
            };

            return componentTabs;
        }

        public IActionResult GetSelectedTabContent(int id)
        {
            switch (id)
            {
                case 0:
                case 1:
                case 2:
                    {
                        SelectionBoxModel selectionBoxModel = new SelectionBoxModel()
                        {
                            GenderId = 1
                        };
                        return PartialView("Editors/_selectboxComponent", selectionBoxModel);
                    }
                default:
                    break;
            }
            return PartialView("_selectboxComponent");
        }

        [HttpGet]
        public LoadResult GetGenederSelectionData(DataSourceLoadOptions loadOptions)
        {
            List<GenderSelectionModel> genderSelectionModel = new List<GenderSelectionModel>();
            genderSelectionModel.Add(new GenderSelectionModel() { Id = 1, Name = "Male" });
            genderSelectionModel.Add(new GenderSelectionModel() { Id = 2, Name = "Female" });
            genderSelectionModel.Add(new GenderSelectionModel() { Id = 3, Name = "Other" });
            return DataSourceLoader.Load(genderSelectionModel, loadOptions); ;
        }
    }
}
