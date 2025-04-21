using MediatR;

namespace Test.Library.Application.Queries.Usuario
{
    public record UsuarioGetAllQuery(): IRequest<IEnumerable<UsuarioGetAllResponse>>
    {
    }
}
