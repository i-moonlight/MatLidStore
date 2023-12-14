using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.CreateOrderEmployeeCommand
{
    public class CreateOrderEmployeeCommandHandler : IRequestHandler<CreateOrderEmployeeCommand, int>
    {
        private readonly IOrderEmployeeRepository _orderEmployeeRepository;
        private readonly IMapper _mapper;

        public CreateOrderEmployeeCommandHandler(IOrderEmployeeRepository orderEmployeeRepository, IMapper mapper)
        {
            _orderEmployeeRepository = orderEmployeeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderEmployeeCommand request, CancellationToken cancellationToken)
        {
            var orderEmployeeToCreate = _mapper.Map<Domain.OrderEmployee>(request);
            await _orderEmployeeRepository.Create(orderEmployeeToCreate);

            return orderEmployeeToCreate.Id;
        }
    }
}
