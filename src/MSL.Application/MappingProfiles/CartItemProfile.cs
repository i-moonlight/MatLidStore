using AutoMapper;
using MLS.Application.DTO.CartItem;
using MLS.Application.Features.CartItem.Commands.CreateCartItemCommand;
using MLS.Application.Features.CartItem.Commands.DeleteCartItemCommand;
using MLS.Application.Features.CartItem.Commands.UpdateCartItemCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class CartItemProfile : Profile
    {
        public CartItemProfile()
        {
            CreateMap<CartItemDto, CartItem>().ReverseMap();
            CreateMap<CartItem, CartItemDetailDto>();
            CreateMap<CartItem, CreateCartItemCommand>();
            CreateMap<CartItem, UpdateCartItemCommand>();
            CreateMap<CartItem, DeleteCartItemCommand>();
        }
    }
}
