using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.DeleteOrderHistoryCommand
{
    public class DeleteOrderHistoryCommandHandler : IRequestHandler<DeleteOrderHistoryCommand, Unit>
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;

        public DeleteOrderHistoryCommandHandler(IOrderHistoryRepository orderHistoryRepository)
        {
            _orderHistoryRepository = orderHistoryRepository;
        }

        public async Task<Unit> Handle(DeleteOrderHistoryCommand request, CancellationToken cancellationToken)
        {
            var orderHistoryToDelete = await _orderHistoryRepository.GetById(request.Id);

            if (orderHistoryToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.OrderHistory), request.Id);
            }

            await _orderHistoryRepository.Delete(orderHistoryToDelete);

            return Unit.Value;
        }
    }
}