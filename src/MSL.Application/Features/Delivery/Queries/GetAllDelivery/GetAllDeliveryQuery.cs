using MediatR;
using MLS.Application.DTO.Delivery;

namespace MLS.Application.Features.Delivery.Queries.GetAllDelivery
{
    public record GetAllDeliveryQuery : IRequest<List<DeliveryDto>>;
}