using AutoMapper;
using net8template.Domain.DTOs.Products;
using net8template.Domain.Interfaces.Application.UseCases.Products;
using net8template.Domain.Interfaces.Infrastructure.Repositories;

namespace net8template.Application.UseCases.Products
{
    public class GetOneProducts : IGetOneProducts
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public GetOneProducts(
                [FromKeyedServices("IProductsRepository")] IProductsRepository productsRepository,
                IMapper mapper
            )
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }
        public async Task<ProductResponseDto?> handle(int id)
        {
            var product = await _productsRepository.GetById(id);

            if (product == null) return null;

            var response = _mapper.Map<ProductResponseDto>(product);

            return response;
        }
    }
};

