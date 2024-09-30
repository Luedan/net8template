using net8template.Application.Profiles;

namespace net8template.Application
{
    public class ApplicationDI
    {
        public static void InjectDependencies(IServiceCollection services) { 
            // AutoMappers Profiles
            services.AddAutoMapper(typeof(ProductsProfile));

            // UseCases

            // Use Cases Services
         }
    }
}
