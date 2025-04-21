using MediatR;

namespace Test.Library.Application.Commands.Libro.Create
{
    public record LibroCreateCommand(): IRequest<bool>
    {
        public int IdGenero { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
