using AutoMapper;
using MediatR;
using Test.Library.Domain.Interfaces;

namespace Test.Library.Application.Queries.Libro.GetAll
{
    public class LibroGetAllHandler(IMapper mapper, ILibroRepository libroRepository) : IRequestHandler<LibroGetAllQuery, IEnumerable<LibroGetAllResponse>>
    {
        private readonly IMapper _mapper = mapper;
        private readonly ILibroRepository _libroRepository = libroRepository;
        public async Task<IEnumerable<LibroGetAllResponse>> Handle(LibroGetAllQuery request, CancellationToken cancellationToken)
        {
            var result = await _libroRepository.GetAll();
            return _mapper.Map<IEnumerable<LibroGetAllResponse>>(result);
        }
    }
}
