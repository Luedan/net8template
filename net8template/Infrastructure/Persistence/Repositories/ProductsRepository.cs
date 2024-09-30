using Microsoft.EntityFrameworkCore;
using net8template.Domain.Interfaces.Infrastructure.Repositories;
using net8template.Domain.Models;

namespace net8template.Infrastructure.Persistence.Repositories
{

    public class ProductsRepository : IProductsRepository
    {
        private readonly ContextApp _context;

        public ProductsRepository(ContextApp context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> GetAll() =>
            await _context.Products.ToListAsync();

        public async Task<Products?> GetById(int id) =>
            await _context.Products.FindAsync(id);

        public async Task Add(Products product) =>
            await _context.Products.AddAsync(product);

        public void Update(Products product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
        }

        public void Delete(Products product)
        {
            _context.Products.Remove(product);
        }

        public async Task Save() =>
            await _context.SaveChangesAsync();
    }

}