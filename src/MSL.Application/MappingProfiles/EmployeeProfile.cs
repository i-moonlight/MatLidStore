using AutoMapper;
using MLS.Application.DTO.Employee;
using MLS.Application.Features.Employee.Commands.CreateEmployeeCommand;
using MLS.Application.Features.Employee.Commands.DeleteEmployeeCommand;
using MLS.Application.Features.Employee.Commands.UpdateEmployeeCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<Employee, EmployeeDetailDto>();
            CreateMap<Employee, CreateEmployeeCommand>();
            CreateMap<Employee, UpdateEmployeeCommand>();
            CreateMap<Employee, DeleteEmployeeCommand>();
        }
    }
}
