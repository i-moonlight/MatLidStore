using MediatR;

namespace MLS.Application.Features.Employee.Commands.DeleteEmployeeCommand
{
    public class DeleteEmployeeCommand : IRequest<Unit>
    {
        public int EmployeeId { get; set; }
    }
}