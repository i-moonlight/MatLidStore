using MediatR;
using MLS.Application.DTO.Order;

namespace MLS.Application.Features.Order.Queries.GetAllOrder
{
    public record GetAllOrderQuery : IRequest<List<OrderDto>>;
}