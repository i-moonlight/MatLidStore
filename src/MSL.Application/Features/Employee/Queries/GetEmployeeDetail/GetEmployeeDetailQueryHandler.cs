using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Employee;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Employee.Queries.GetEmployeeDetail
{
    public class GetEmployeeDetailQueryHandler : IRequestHandler<GetEmployeeDetailQuery, EmployeeDetailDto>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeDetailQueryHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeDetailDto> Handle(GetEmployeeDetailQuery request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetById(request.Id);

            if (employee == null)
                throw new NotFoundException(nameof(Domain.Employee), request.Id);

            var data = _mapper.Map<EmployeeDetailDto>(employee);

            return data;
        }
    }
}