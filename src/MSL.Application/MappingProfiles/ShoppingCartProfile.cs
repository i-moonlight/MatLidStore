using AutoMapper;
using MLS.Application.DTO.ShoppingCart;
using MLS.Application.Features.ShoppingCart.Commands.CreateShoppingCartCommand;
using MLS.Application.Features.ShoppingCart.Commands.DeleteShoppingCartCommand;
using MLS.Application.Features.ShoppingCart.Commands.UpdateShoppingCartCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class ShoppingCartProfile : Profile
    {
        public ShoppingCartProfile()
        {
            CreateMap<ShoppingCartDto, ShoppingCart>().ReverseMap();
            CreateMap<ShoppingCart, ShoppingCartDetailDto>();
            CreateMap<ShoppingCart, CreateShoppingCartCommand>();
            CreateMap<ShoppingCart, UpdateShoppingCartCommand>();
            CreateMap<ShoppingCart, DeleteShoppingCartCommand>();
        }
    }
}
