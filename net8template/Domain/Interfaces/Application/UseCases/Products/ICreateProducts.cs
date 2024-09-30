using net8template.Domain.DTOs.Products;

namespace net8template.Domain.Interfaces.Application.UseCases.Products
{
    public interface ICreateProducts
    {
        public Task<ProductResponseDto> handle(ProductInsertDto product);
    }
}

