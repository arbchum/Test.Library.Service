using MediatR;

namespace Test.Library.Application.Queries.Libro.GetAll
{
    public record LibroGetAllQuery(): IRequest<IEnumerable<LibroGetAllResponse>>
    {
    }
}
