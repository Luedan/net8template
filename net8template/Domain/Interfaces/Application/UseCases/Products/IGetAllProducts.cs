
using net8template.Domain.DTOs.Products;

namespace net8template.Domain.Interfaces.Application.UseCases.Products
{
    public interface IGetAllProducts
    {
        public Task<IEnumerable<ProductResponseDto>> handle();
    }
};

