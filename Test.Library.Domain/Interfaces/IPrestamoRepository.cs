using Test.Library.Domain.Entities;

namespace Test.Library.Domain.Interfaces
{
    public interface IPrestamoRepository
    {
        Task<bool> Create(PrestamoEntity entity);
        Task<IEnumerable<PrestamoEntity>> GetAll(int? idCliente);
    }
}
