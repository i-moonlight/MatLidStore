using MediatR;
using MLS.Application.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Employee.Queries.GetEmployeeDetail
{
    public record GetEmployeeDetailQuery(int Id) : IRequest<EmployeeDetailDto>;
}
