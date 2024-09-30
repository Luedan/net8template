using Microsoft.EntityFrameworkCore;
using net8template.Domain.Interfaces.Infrastructure.Repositories;
using net8template.Infrastructure.Persistence;
using net8template.Infrastructure.Persistence.Repositories;

namespace net8template.Infrastructure
{
    public class InfrastructureDI
    {
        public static void InjectDependencies(IServiceCollection service)
        {
            // Context App
            service.AddDbContextPool<ContextApp>(opt =>
                opt.UseNpgsql(Environment.GetEnvironmentVariable("CONN_STRING")));

            // Repositories
            service.AddKeyedScoped<IProductsRepository, ProductsRepository>("IProductsRepository");
        }
    }
}
