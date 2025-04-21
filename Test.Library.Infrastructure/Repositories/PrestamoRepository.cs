using Microsoft.EntityFrameworkCore;
using Test.Library.Domain.Entities;
using Test.Library.Domain.Interfaces;
using Test.Library.Infrastructure.Persistence;

namespace Test.Library.Infrastructure.Repositories
{
    public class PrestamoRepository(DbLibraryContext context) : IPrestamoRepository
    {
        private readonly DbLibraryContext _context = context;
        public async Task<bool> Create(PrestamoEntity entity)
        {
            await _context.Prestamos.AddAsync(entity);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<IEnumerable<PrestamoEntity>> GetAll(int? idCliente)
        {
            var query = _context.Prestamos
                        .Include(p => p.Cliente)
                        .Include(p => p.Detalle)
                        .AsQueryable();

            if (idCliente.HasValue)
            {
                query = query.Where(p => p.IdCliente == idCliente.Value);
            }

            return await query.ToListAsync();
        }
    }
}
