using MediatR;
using MLS.Application.DTO.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Address.Queries.GetAllAddress
{
    public record GetAllAddressQuery : IRequest<List<AddressDto>>;
}
