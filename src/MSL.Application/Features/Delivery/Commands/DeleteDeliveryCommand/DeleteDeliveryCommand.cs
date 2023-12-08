using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Delivery.Commands.DeleteDeliveryCommand
{
    public class DeleteDeliveryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
