using MediatR;
using MLS.Application.DTO.Order;

namespace MLS.Application.Features.Order.Queries.GetOrderDetail
{
    public record GetOrderDetailQuery(int Id) : IRequest<OrderDetailDto>;
}