using AutoMapper;
using MLS.Application.DTO.Order;
using MLS.Application.Features.Order.Commands.CreateOrderCommand;
using MLS.Application.Features.Order.Commands.DeleteOrderCommand;
using MLS.Application.Features.Order.Commands.UpdateOrderCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<Order, OrderDetailDto>();
            CreateMap<Order, CreateOrderCommand>();
            CreateMap<Order, UpdateOrderCommand>();
            CreateMap<Order, DeleteOrderCommand>();
        }
    }
}
