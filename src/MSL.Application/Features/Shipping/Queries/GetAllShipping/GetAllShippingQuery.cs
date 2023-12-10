using MediatR;
using MLS.Application.DTO.Shipping;

namespace MLS.Application.Features.Shipping.Queries.GetAllShipping
{
    public record GetAllShippingQuery : IRequest<List<ShippingDto>>;
}