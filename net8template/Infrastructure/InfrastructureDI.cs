using Microsoft.EntityFrameworkCore;
using net8template.Infrastructure.Persistence;

namespace net8template.Infrastructure
{
    public class InfrastructureDI
    {
        public static void InjectDependencies (IServiceCollection service) {
            // Context App
            service.AddDbContextPool<ContextApp>(opt =>
                opt.UseNpgsql(Environment.GetEnvironmentVariable("CONN_STRING")));
        }
    }
}
