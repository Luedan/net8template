
using AutoMapper;
using net8template.Domain.DTOs.Products;
using net8template.Domain.Interfaces.Application.UseCases.Products;
using net8template.Domain.Interfaces.Infrastructure.Repositories;

namespace net8template.Application.UseCases.Products
{
    public class GetAllProducts : IGetAllProducts
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public GetAllProducts(
                [FromKeyedServices("IProductsRepository")] IProductsRepository productsRepository,
                IMapper mapper
            )
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponseDto>> handle()
        {
            var products = await _productsRepository.GetAll();
            var response = products.Select(_mapper.Map<ProductResponseDto>);

            return response;
        }
    }
};

