using AutoMapper;
using MLS.Application.DTO.Product;
using MLS.Application.Features.Product.Commands.CreateProductSupplierCommand;
using MLS.Application.Features.Product.Commands.DeleteProductSupplierCommand;
using MLS.Application.Features.Product.Commands.UpdateProductSupplierCommand;
using MLS.Domain;

namespace MLS.Application.MappingProfiles
{
    public class ProductSupplierProfile : Profile
    {
        public ProductSupplierProfile()
        {
            CreateMap<ProductSupplierDto, ProductSupplier>().ReverseMap();
            CreateMap<ProductSupplier, ProductSupplierDetailDto>();
            CreateMap<ProductSupplier, CreateProductSupplierCommand>();
            CreateMap<ProductSupplier, UpdateProductSupplierCommand>();
            CreateMap<ProductSupplier, DeleteProductSupplierCommand>();
        }
    }
}
