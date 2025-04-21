using MediatR;

namespace Test.Library.Application.Commands.Prestamo.Create
{
    public record PrestamoCreateCommand(): IRequest<bool>
    {
        public short IdCliente { get; set; }
        public List<PrestamoLibrosDto> Detalle { get; set; } = [];
    }
    public class PrestamoLibrosDto
    {
        public short IdLibro { get; set; }
    }
}
