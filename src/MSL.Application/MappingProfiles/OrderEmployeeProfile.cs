using AutoMapper;
using MLS.Application.DTO.Order;
using MLS.Application.Features.Order.Commands.CreateOrderEmployeeCommand;
using MLS.Application.Features.Order.Commands.DeleteOrderEmployeeCommand;
using MLS.Application.Features.Order.Commands.UpdateOrderEmployeeCommand;
using MLS.Domain;

namespace MLS.Application.MappingProfiles
{
    public class OrderEmployeeProfile : Profile
    {
        public OrderEmployeeProfile()
        {
            CreateMap<OrderEmployeeDto, OrderEmployee>().ReverseMap();
            CreateMap<OrderEmployee, OrderEmployeeDetailDto>();
            CreateMap<OrderEmployee, CreateOrderEmployeeCommand>();
            CreateMap<OrderEmployee, UpdateOrderEmployeeCommand>();
            CreateMap<OrderEmployee, DeleteOrderEmployeeCommand>();
        }
    }
}
