using AutoMapper;
using MediatR;
using Test.Library.Domain.Interfaces;

namespace Test.Library.Application.Queries.Usuario
{
    public class UsuarioGetAllHandler(IUsuarioRepository usuarioRepository, IMapper mapper) : IRequestHandler<UsuarioGetAllQuery, IEnumerable<UsuarioGetAllResponse>>
    {
        private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<IEnumerable<UsuarioGetAllResponse>> Handle(UsuarioGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = await _usuarioRepository.GetUsuarios();
            return _mapper.Map<IEnumerable<UsuarioGetAllResponse>>(response);
        }
    }
}
