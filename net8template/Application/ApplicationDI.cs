using net8template.Application.Profiles;
using net8template.Application.UseCases.Products;
using net8template.Domain.Interfaces.Application.UseCases.Products;

namespace net8template.Application
{
    public class ApplicationDI
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            // AutoMappers Profiles
            services.AddAutoMapper(typeof(ProductsProfile));

            // UseCases
            services.AddKeyedScoped<IGetAllProducts, GetAllProducts>("IGetAllProducts");
            services.AddKeyedScoped<IGetOneProducts, GetOneProducts>("IGetOneProducts");
            services.AddKeyedScoped<ICreateProducts, CreateProducts>("ICreateProducts");
            services.AddKeyedScoped<IUpdateProducts, UpdateProducts>("IUpdateProducts");
            services.AddKeyedScoped<IDeleteProducts, DeleteProducts>("IDeleteProducts");

            // Use Cases Services
        }
    }
}
