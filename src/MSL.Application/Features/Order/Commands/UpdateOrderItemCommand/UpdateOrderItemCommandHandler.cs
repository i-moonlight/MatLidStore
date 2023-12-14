using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Domain;

namespace MLS.Application.Features.Order.Commands.UpdateOrderItemCommand
{
    public class UpdateOrderItemCommandHandler : IRequestHandler<UpdateOrderItemCommand, Unit>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public UpdateOrderItemCommandHandler(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var orderItemToUpdate = _mapper.Map<OrderItem>(request);
            await _orderItemRepository.Update(orderItemToUpdate);

            return Unit.Value;
        }
    }
}