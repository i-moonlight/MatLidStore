using AutoMapper;
using MLS.Application.DTO.Product;
using MLS.Application.Features.Product.Commands.CreateProductCommand;
using MLS.Application.Features.Product.Commands.DeleteProductCommand;
using MLS.Application.Features.Product.Commands.UpdateProductCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<Product, ProductDetailDto>();
            CreateMap<Product, CreateProductCommand>();
            CreateMap<Product, UpdateProductCommand>();
            CreateMap<Product, DeleteProductCommand>();
        }
    }
}
