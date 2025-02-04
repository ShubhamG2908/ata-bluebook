using ATA.Web.Common.Helpers;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DxUserController : Controller
    {
        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
            {
            return Ok(DummyDataHelper.GetDummyUserData());
        }

        [HttpPost]
        public IActionResult Post([FromForm] string value)
        {
            return Ok();
        }
    }
}
