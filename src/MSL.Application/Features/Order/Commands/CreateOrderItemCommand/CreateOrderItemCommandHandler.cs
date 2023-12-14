using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Order.Commands.CreateOrderItemCommand
{
    public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, int>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public CreateOrderItemCommandHandler(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var orderItemToCreate = _mapper.Map<Domain.OrderItem>(request);
            await _orderItemRepository.Create(orderItemToCreate);

            return orderItemToCreate.Id;
        }
    }
}