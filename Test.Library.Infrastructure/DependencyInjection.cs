using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test.Library.Domain.Interfaces;
using Test.Library.Infrastructure.Persistence;
using Test.Library.Infrastructure.Repositories;

namespace Test.Library.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<DbLibraryContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ILibroRepository, LibroRepository>();
            services.AddScoped<IPrestamoRepository, PrestamoRepository>();
            return services;
        }
    }
}
