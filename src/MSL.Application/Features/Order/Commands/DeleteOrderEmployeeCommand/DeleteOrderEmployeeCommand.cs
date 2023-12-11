using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.DeleteOrderEmployeeCommand
{
    public class DeleteOrderEmployeeCommand : IRequest<Unit>
    {
        public int OrderEmployeeId { get; set; }
    }
}
