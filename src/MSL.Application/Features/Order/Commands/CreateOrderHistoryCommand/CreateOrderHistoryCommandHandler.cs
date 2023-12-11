using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.CreateOrderHistoryCommand
{
    public class CreateOrderHistoryCommandHandler : IRequestHandler<CreateOrderHistoryCommand, int>
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IMapper _mapper;

        public CreateOrderHistoryCommandHandler(IOrderHistoryRepository orderHistoryRepository, IMapper mapper)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderHistoryCommand request, CancellationToken cancellationToken)
        {
            var orderHistoryToCreate = _mapper.Map<Domain.OrderHistory>(request);
            await _orderHistoryRepository.Create(orderHistoryToCreate);

            return orderHistoryToCreate.Id;
        }
    }
}
