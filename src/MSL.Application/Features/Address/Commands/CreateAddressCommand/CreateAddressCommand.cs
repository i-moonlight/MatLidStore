using MediatR;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Address.Commands.CreateAddressCommand
{
    public class CreateAddressCommand : IRequest<int>
    {
    }
}
