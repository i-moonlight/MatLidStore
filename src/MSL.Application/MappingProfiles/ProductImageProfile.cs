using AutoMapper;
using MLS.Application.DTO.Product;
using MLS.Application.Features.Product.Commands.CreateProductImageCommand;
using MLS.Application.Features.Product.Commands.DeleteProductImageCommand;
using MLS.Application.Features.Product.Commands.UpdateProductImageCommand;
using MLS.Domain;

namespace MLS.Application.MappingProfiles
{
    public class ProductImageProfile : Profile
    {
        public ProductImageProfile()
        {
            CreateMap<ProductImageDto, ProductImage>().ReverseMap();
            CreateMap<ProductImage, ProductImageDetailDto>();
            CreateMap<ProductImage, CreateProductImageCommand>();
            CreateMap<ProductImage, UpdateProductImageCommand>();
            CreateMap<ProductImage, DeleteProductImageCommand>();
        }
    }
}
