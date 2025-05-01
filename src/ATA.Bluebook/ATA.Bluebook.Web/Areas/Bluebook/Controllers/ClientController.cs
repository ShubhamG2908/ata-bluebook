using ATA.Application.Services.Bluebook.Client.Get;
using ATA.Application.Services.Shared.User.Login;
using ATA.Web.Common.Helpers;
using DevExtreme.AspNet.Mvc;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace ATA.Web.Areas.Bluebook.Controllers
{
    [Area("Bluebook")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            var getAll = await _mediator.Send(new GetAllClientsQuery());
            return Ok(getAll);
        }

        [HttpPost]
        public IActionResult Post([FromForm] string value)
        {
            return Ok();
        }
    }
}
