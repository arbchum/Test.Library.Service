using AutoMapper;
using MediatR;
using Test.Library.Domain.Entities;
using Test.Library.Domain.Interfaces;

namespace Test.Library.Application.Commands.Libro.Create
{
    public class LibroCreateHandler(IMapper mapper, ILibroRepository libroRepository) : IRequestHandler<LibroCreateCommand, bool>
    {
        public readonly IMapper _mapper = mapper;
        private readonly ILibroRepository _libroRepository = libroRepository;

        public async Task<bool> Handle(LibroCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<LibroCreateCommand, LibroEntity>(request);
            var result = await _libroRepository.Create(entity);
            return result;
        }
    }
}
