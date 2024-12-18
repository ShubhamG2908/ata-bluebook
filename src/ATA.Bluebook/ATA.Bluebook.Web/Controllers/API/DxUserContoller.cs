using ATA.Bluebook.Web.Common.Helpers;

using Microsoft.AspNetCore.Mvc;

namespace ATA.Bluebook.Web.Controllers.API
{
    public class DxUserContoller : Controller
    {
        public IActionResult Get()
        {
            return Ok(DummyDataHelper.GetDummyUserData());
        }
    }
}
