using AutoMapper;
using MediatR;
using Test.Library.Domain.Interfaces;

namespace Test.Library.Application.Queries.Prestamo.GetAll
{
    public class PrestamoGetAllHandler(IMapper mapper, IPrestamoRepository prestamoRepository) : IRequestHandler<PrestamoGetAllQuery, IEnumerable<PrestamoGetAllResponse>>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IPrestamoRepository _prestamoRepository = prestamoRepository;
        public async Task<IEnumerable<PrestamoGetAllResponse>> Handle(PrestamoGetAllQuery query, CancellationToken cancellationToken)
        {
            var result = await _prestamoRepository.GetAll(query.IdCliente);
            return _mapper.Map<IEnumerable<PrestamoGetAllResponse>>(result);
        }
    }
}
