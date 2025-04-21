using Microsoft.EntityFrameworkCore;
using Test.Library.Domain.Entities;
using Test.Library.Domain.Interfaces;
using Test.Library.Infrastructure.Persistence;

namespace Test.Library.Infrastructure.Repositories
{
    public class LibroRepository(DbLibraryContext context): ILibroRepository
    {
        private readonly DbLibraryContext _context = context;

        public async Task<bool> Create(LibroEntity entity)
        {
            await _context.Libros.AddAsync(entity);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<IEnumerable<LibroEntity>> GetAll()
        {
            var result = await _context.Libros.ToListAsync();
            return result;
        }
    }
}
