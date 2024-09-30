using net8template.Domain.Models;

namespace net8template.Domain.Interfaces.Infrastructure.Repositories
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Products>> GetAll();

        Task<Products?> GetById(int id);

        Task Add(Products product);

        void Update(Products product);

        void Delete(Products product);

        Task Save();
    }
};


