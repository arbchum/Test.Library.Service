using Test.Library.Domain.Entities;

namespace Test.Library.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioEntity>> GetUsuarios();
    }
}
