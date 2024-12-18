using ATA.Bluebook.Web.Common.Helpers;

using DevExtreme.AspNet.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

using Newtonsoft.Json;

namespace ATA.Bluebook.Web.Controllers.API
{
    public class DxUserController : Controller
    {
        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
            {
            return Ok(DummyDataHelper.GetDummyUserData());
        }

        [HttpPost]
        public IActionResult Create([FromForm] string values)
        {
            return Ok();
        }
    }
}
