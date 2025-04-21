using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Library.Application.Commands.Prestamo.Create;
using Test.Library.Application.Queries.Libro.GetAll;
using Test.Library.Application.Queries.Prestamo.GetAll;

namespace Test.Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> Create([FromBody] PrestamoCreateCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<PrestamoGetAllResponse>>> GetAll([FromQuery] PrestamoGetAllQuery query)
        {
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
