using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Address.Commands.DeleteAddressCommand
{
    public class DeleteAddressCommand : IRequest<Unit>
    {
        public int AddressId { get; set; }
    }
}
