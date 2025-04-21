using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Library.Application.Queries.Usuario;

namespace Test.Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<UsuarioGetAllResponse>>> GetUsuarios()
        {
            var query = new UsuarioGetAllQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }
    }
}
