using MediatR;
using MLS.Application.DTO.Delivery;

namespace MLS.Application.Features.Delivery.Queries.GetDeliveryDetail
{
    public record GetDeliveryDetailQuery(int Id) : IRequest<DeliveryDetailDto>;
}