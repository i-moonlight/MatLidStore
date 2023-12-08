using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Employee.Commands.DeleteEmployeeCommand
{
    public class DeleteEmployeeCommand : IRequest<Unit>
    {
        public int EmployeeId { get; set; }
    }
}
