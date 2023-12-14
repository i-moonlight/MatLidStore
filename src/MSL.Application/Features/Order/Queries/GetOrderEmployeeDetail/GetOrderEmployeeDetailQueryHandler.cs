using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Order;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetOrderEmployeeDetail
{
    public class GetOrderEmployeeDetailQueryHandler : IRequestHandler<GetOrderEmployeeDetailQuery, OrderEmployeeDetailDto>
    {
        private readonly IOrderEmployeeRepository _orderEmployeeRepository;
        private readonly IMapper _mapper;

        public GetOrderEmployeeDetailQueryHandler(IOrderEmployeeRepository orderEmployeeRepository, IMapper mapper)
        {
            _orderEmployeeRepository = orderEmployeeRepository;
            _mapper = mapper;
        }

        public async Task<OrderEmployeeDetailDto> Handle(GetOrderEmployeeDetailQuery request, CancellationToken cancellationToken)
        {
            var orderEmployee = await _orderEmployeeRepository.GetById(request.Id);

            if (orderEmployee == null)
            {
                throw new NotFoundException(nameof(Domain.OrderEmployee), request.Id);
            }

            var data = _mapper.Map<OrderEmployeeDetailDto>(orderEmployee);

            return data;
        }
    }
}
