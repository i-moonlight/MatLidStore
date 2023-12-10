using MediatR;
using MLS.Application.DTO.Employee;

namespace MLS.Application.Features.Employee.Queries.GetEmployeeDetail
{
    public record GetEmployeeDetailQuery(int Id) : IRequest<EmployeeDetailDto>;
}