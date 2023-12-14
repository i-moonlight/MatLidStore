using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.UpdateOrderEmployeeCommand
{
    public class UpdateOrderEmployeeCommandHandler : IRequestHandler<UpdateOrderEmployeeCommand, Unit>
    {
        private readonly IOrderEmployeeRepository _orderEmployeeRepository;
        private readonly IMapper _mapper;

        public UpdateOrderEmployeeCommandHandler(IOrderEmployeeRepository orderEmployeeRepository, IMapper mapper)
        {
            _orderEmployeeRepository = orderEmployeeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOrderEmployeeCommand request, CancellationToken cancellationToken)
        {
            var orderEmployeeToUpdate = _mapper.Map<Domain.OrderEmployee>(request);
            await _orderEmployeeRepository.Update(orderEmployeeToUpdate);

            return Unit.Value;
        }
    }
}