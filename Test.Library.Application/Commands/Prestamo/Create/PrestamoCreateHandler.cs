using AutoMapper;
using MediatR;
using Test.Library.Domain.Entities;
using Test.Library.Domain.Interfaces;

namespace Test.Library.Application.Commands.Prestamo.Create
{
    public class PrestamoCreateHandler(IMapper mapper, IPrestamoRepository prestamoRepository) : IRequestHandler<PrestamoCreateCommand, bool>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IPrestamoRepository _prestamoRepository = prestamoRepository;
        public Task<bool> Handle(PrestamoCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<PrestamoEntity>(request);
            var result = _prestamoRepository.Create(entity);
            return result;
        }
    }
}
