using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.DeleteOrderEmployeeCommand
{
    public class DeleteOrderEmployeeCommandHandler : IRequestHandler<DeleteOrderEmployeeCommand, Unit>
    {
        private readonly IOrderEmployeeRepository _orderEmployeeRepository;

        public DeleteOrderEmployeeCommandHandler(IOrderEmployeeRepository orderEmployeeRepository)
        {
            _orderEmployeeRepository = orderEmployeeRepository;
        }

        public async Task<Unit> Handle(DeleteOrderEmployeeCommand request, CancellationToken cancellationToken)
        {
            var orderEmployeeToDelete = await _orderEmployeeRepository.GetById(request.OrderEmployeeId);

            if (orderEmployeeToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.OrderEmployee), request.OrderEmployeeId);
            }

            await _orderEmployeeRepository.Delete(orderEmployeeToDelete);

            return Unit.Value;
        }
    }
}