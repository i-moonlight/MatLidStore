using MediatR;
using MLS.Application.DTO.Address;

namespace MLS.Application.Features.Address.Queries.GetAllAddress
{
    public record GetAllAddressQuery : IRequest<List<AddressDto>>;
}