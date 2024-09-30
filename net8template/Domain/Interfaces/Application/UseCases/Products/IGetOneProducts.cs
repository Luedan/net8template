
using net8template.Domain.DTOs.Products;

namespace net8template.Domain.Interfaces.Application.UseCases.Products
{
    public interface IGetOneProducts
    {
        public Task<ProductResponseDto?> handle(int id);
    }
};

