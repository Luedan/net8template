using AutoMapper;
using net8template.Domain.DTOs.Products;
using net8template.Domain.Interfaces.Application.UseCases.Products;
using net8template.Domain.Interfaces.Infrastructure.Repositories;
using net8template.Domain.Models;

namespace net8template.Application.UseCases.Products
{
    public class UpdateProducts : IUpdateProducts
    {

        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public UpdateProducts(
                [FromKeyedServices("IProductsRepository")] IProductsRepository productsRepository,
                IMapper mapper
            )
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<ProductResponseDto?> handle(int id, ProductUpdateDto productUpdate)
        {
            var product = await _productsRepository.GetById(id);

            if (product == null) return null;

            var productUpdateMap = _mapper.Map<ProductUpdateDto, Product>(productUpdate, product);

            _productsRepository.Update(productUpdateMap);

            await _productsRepository.Save();

            var response = _mapper.Map<ProductResponseDto>(productUpdateMap);

            return response;
        }
    }
};

