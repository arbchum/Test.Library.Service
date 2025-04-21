using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Test.Library.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
           
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(delegate(MediatRServiceConfiguration options)
            {
                options.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}
