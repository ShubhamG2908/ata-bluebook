using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using ATA.Bluebook.Web.Models.User;

namespace ATA.Bluebook.Web.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Users");
        }
        
        public IActionResult Users()
        {
            return View();
        }

        public IActionResult ListName()
        {
            return View();
        }

        public IActionResult QuickCostDataEntry()
        {
            return View();
        }

        [HttpGet]
        public LoadResult GetClientList(DataSourceLoadOptions loadOptions)
        {
            List<ClientSelectionModel> clientSelectionModel = new List<ClientSelectionModel>();
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 1, Name = "Client 1" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 2, Name = "Client 2" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 3, Name = "Client 3" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 4, Name = "Client 4" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 5, Name = "Client 5" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 6, Name = "Client 6" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 7, Name = "Client 7" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 8, Name = "Client 8" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 9, Name = "Client 9" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 10, Name = "Client 10" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 11, Name = "Client 11" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 12, Name = "Client 12" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 13, Name = "Client 13" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 14, Name = "Client 14" });
            clientSelectionModel.Add(new ClientSelectionModel() { Id = 15, Name = "Client 15" });
            return DataSourceLoader.Load(clientSelectionModel, loadOptions); ;
        }
    }
}
