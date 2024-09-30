using net8template.Domain.Models;

namespace net8template.Domain.Interfaces.Infrastructure.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product?> GetById(int id);

        Task Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        Task Save();
    }
};


