using Test.Library.Domain.Entities;

namespace Test.Library.Domain.Interfaces
{
    public interface ILibroRepository
    {
        Task<bool> Create(LibroEntity entity);
        Task<IEnumerable<LibroEntity>> GetAll();
    }
}
