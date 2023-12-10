using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Order.Commands.DeleteOrderCommand
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;

        public DeleteOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var orderToDelete = await _orderRepository.GetById(request.Id);

            if (orderToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Order), request.Id);
            }

            await _orderRepository.Delete(orderToDelete);

            return Unit.Value;
        }
    }
}