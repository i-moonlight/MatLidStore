using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Employee.Commands.DeleteEmployeeCommand
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeToDelete = await _employeeRepository.GetById(request.EmployeeId);

            if (employeeToDelete == null)
                throw new NotFoundException(nameof(Domain.Employee), request.EmployeeId);

            await _employeeRepository.Delete(employeeToDelete);

            return Unit.Value;
        }
    }
}