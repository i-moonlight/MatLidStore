using AutoMapper;
using MLS.Application.DTO.Order;
using MLS.Application.Features.Order.Commands.CreateOrderHistoryCommand;
using MLS.Application.Features.Order.Commands.DeleteOrderHistoryCommand;
using MLS.Application.Features.Order.Commands.UpdateOrderHistoryCommand;
using MLS.Domain;

namespace MLS.Application.MappingProfiles
{
    public class OrderHistoryProfile : Profile
    {
        public OrderHistoryProfile()
        {
            CreateMap<OrderHistoryDto, OrderHistory>().ReverseMap();
            CreateMap<OrderHistory, OrderHistoryDetailDto>();
            CreateMap<OrderHistory, CreateOrderHistoryCommand>();
            CreateMap<OrderHistory, UpdateOrderHistoryCommand>();
            CreateMap<OrderHistory, DeleteOrderHistoryCommand>();
        }
    }
}