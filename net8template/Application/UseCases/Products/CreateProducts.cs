
using AutoMapper;
using net8template.Domain.DTOs.Products;
using net8template.Domain.Interfaces.Application.UseCases.Products;
using net8template.Domain.Interfaces.Infrastructure.Repositories;
using net8template.Domain.Models;

namespace net8template.Application.UseCases.Products
{
    public class CreateProducts : ICreateProducts
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public CreateProducts(
                [FromKeyedServices("IProductsRepository")] IProductsRepository productsRepository,
                IMapper mapper
            )
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }
        public async Task<ProductResponseDto> handle(ProductInsertDto product)
        {
            var productInsert = _mapper.Map<Product>(product);

            await _productsRepository.Add(productInsert);

            await _productsRepository.Save();

            var response = _mapper.Map<ProductResponseDto>(productInsert);

            return response;
        }
    }
};

