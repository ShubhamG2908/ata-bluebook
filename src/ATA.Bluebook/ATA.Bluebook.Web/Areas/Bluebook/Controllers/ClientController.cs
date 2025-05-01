using ATA.Application.Models.Bluebook;
using ATA.Application.Services.Bluebook.Client.List;
using ATA.Application.Services.Bluebook.Client.Save;

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
        [HttpGet]
        public IActionResult Add()
        {
            return View(new ClientModel()); // Pass empty model to the view
        }
        //[HttpGet]
        //public async Task<IActionResult> Edit(Guid id)
        //{
        //    var client = await _mediator.Send(new GetClientByIdQuery(id)); // You'll need to implement this query/handler
        //    if (client == null)
        //        return NotFound();

        //    return View("Add", client); // Reuse Add.cshtml for both Add and Edit
        //}

        [HttpPost]
        public async Task<IActionResult> Save(ClientModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new SaveClientCommand(model);
            var result = await _mediator.Send(command);

            if (result.Success)
            {
                return RedirectToAction("Index");  // Or a success page, depending on your flow
            }

            return BadRequest(result.ErrorMessage);
        }
    }
}
