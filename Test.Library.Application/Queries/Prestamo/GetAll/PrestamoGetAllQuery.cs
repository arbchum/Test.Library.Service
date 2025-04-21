using MediatR;

namespace Test.Library.Application.Queries.Prestamo.GetAll
{
    public record PrestamoGetAllQuery(): IRequest<IEnumerable<PrestamoGetAllResponse>>
    {
        public int? IdCliente { get; set; }
    }
}
