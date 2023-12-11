using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetAllOrderEmployee
{
    public class GetAllOrderEmployeeQueryHandler : IRequestHandler<GetAllOrderEmployeeQuery, List<OrderEmployeeDto>>
    {
        private readonly IOrderEmployeeRepository _orderEmployeeRepository;
        private readonly IMapper _mapper;

        public GetAllOrderEmployeeQueryHandler(IOrderEmployeeRepository orderEmployeeRepository, IMapper mapper)
        {
            _orderEmployeeRepository = orderEmployeeRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderEmployeeDto>> Handle(GetAllOrderEmployeeQuery request, CancellationToken cancellationToken)
        {
            var orderEmployees = await _orderEmployeeRepository.GetAll();
            var data = _mapper.Map<List<OrderEmployeeDto>>(orderEmployees);

            return data;
        }
    }
}
