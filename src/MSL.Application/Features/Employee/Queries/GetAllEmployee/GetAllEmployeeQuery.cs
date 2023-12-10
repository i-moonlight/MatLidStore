using MediatR;
using MLS.Application.DTO.Employee;

namespace MLS.Application.Features.Employee.Queries.GetAllEmployee
{
    public record GetAllEmployeeQuery : IRequest<List<EmployeeDto>>;
}