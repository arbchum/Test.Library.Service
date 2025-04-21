using Microsoft.EntityFrameworkCore;
using Test.Library.Domain.Entities;
using Test.Library.Domain.Interfaces;
using Test.Library.Infrastructure.Persistence;

namespace Test.Library.Infrastructure.Repositories
{
    public class UsuarioRepository(DbLibraryContext context) : IUsuarioRepository
    {
        private readonly DbLibraryContext _context = context;

        public async Task<IEnumerable<UsuarioEntity>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
