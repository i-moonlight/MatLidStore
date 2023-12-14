using AutoMapper;
using MLS.Application.DTO.Order;
using MLS.Application.Features.Order.Commands.CreateOrderItemCommand;
using MLS.Application.Features.Order.Commands.DeleteOrderItemCommand;
using MLS.Application.Features.Order.Commands.UpdateOrderItemCommand;
using MLS.Domain;

namespace MLS.Application.MappingProfiles
{
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile()
        {
            CreateMap<OrderItemDto, OrderItem>().ReverseMap();
            CreateMap<OrderItem, OrderItemDetailDto>();
            CreateMap<OrderItem, CreateOrderItemCommand>();
            CreateMap<OrderItem, UpdateOrderItemCommand>();
            CreateMap<OrderItem, DeleteOrderItemCommand>();
        }
    }
}
