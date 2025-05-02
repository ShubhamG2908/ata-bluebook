using ATA.Domain.Common;

using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Areas.Bluebook.Controllers
{
    [Area("Bluebook")]
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

    }
}
