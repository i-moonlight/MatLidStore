using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Order.Commands.DeleteOrderItemCommand
{
    public class DeleteOrderItemCommandHandler : IRequestHandler<DeleteOrderItemCommand, Unit>
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public DeleteOrderItemCommandHandler(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public async Task<Unit> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
        {
            var orderItemToDelete = await _orderItemRepository.GetById(request.Id);

            if (orderItemToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.OrderItem), request.Id);
            }

            await _orderItemRepository.Delete(orderItemToDelete);

            return Unit.Value;
        }
    }
}