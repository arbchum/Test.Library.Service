using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Library.Application.Commands.Libro.Create;
using Test.Library.Application.Queries.Libro.GetAll;

namespace Test.Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> Create([FromBody] LibroCreateCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<LibroGetAllResponse>>> GetAll([FromQuery] LibroGetAllQuery query)
        {
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
