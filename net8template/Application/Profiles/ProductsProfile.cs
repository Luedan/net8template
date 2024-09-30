using AutoMapper;
using net8template.Domain.DTOs.Products;
using net8template.Domain.Models;

namespace net8template.Application.Profiles
{
    public class ProductsProfile: Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductResponseDto>();
            CreateMap<ProductInsertDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
        }

    }
};


