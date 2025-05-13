using ATA.Domain.Common;

using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Areas.Bluebook.Controllers
{
    [Area("Bluebook")]
    [Route("Bluebook/[controller]")]
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProgramType()
        {
            var enumValues = Enum.GetValues(typeof(ProgramType))
                .Cast<ProgramType>()
                .Select(e => new
                {
                    Value = (int)e,
                    Text = e.ToString()
                });

            return Json(enumValues);
        }
        [HttpGet("{enumName}")]
        public IActionResult GetEnumValues(string enumName)
        {
            var enumType = AppDomain.CurrentDomain.GetAssemblies()
       .SelectMany(a => a.GetTypes())
       .FirstOrDefault(t => t.IsEnum && t.Name.Equals(enumName, StringComparison.OrdinalIgnoreCase));

            if (enumType == null)
            {
                return BadRequest("Invalid enum type.");
            }

            var enumValues = Enum.GetValues(enumType)
                .Cast<object>()
                .Select(e => new
                {
                    Value = (int)e,
                    Text = e.ToString()
                });

            return Ok(enumValues);
        }

    }
}
