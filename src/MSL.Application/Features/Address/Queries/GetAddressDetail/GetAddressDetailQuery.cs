using MediatR;
using MLS.Application.DTO.Address;

namespace MLS.Application.Features.Address.Queries.GetAddressDetail
{
    public record GetAddressDetailQuery(int Id) : IRequest<AddressDetailDto>;
}