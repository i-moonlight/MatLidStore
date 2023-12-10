using MediatR;
using MLS.Application.DTO.Shipping;

namespace MLS.Application.Features.Shipping.Queries.GetShippingDetail
{
    public record GetShippingDetailQuery(int Id) : IRequest<ShippingDetailDto>;
}