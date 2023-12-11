using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Commands.UpdateOrderHistoryCommand
{
    public class UpdateOrderHistoryCommandHandler : IRequestHandler<UpdateOrderHistoryCommand, Unit>
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IMapper _mapper;

        public UpdateOrderHistoryCommandHandler(IOrderHistoryRepository orderHistoryRepository, IMapper mapper)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOrderHistoryCommand request, CancellationToken cancellationToken)
        {
            var orderHistoryToUpdate = _mapper.Map<Domain.OrderHistory>(request);
            await _orderHistoryRepository.Update(orderHistoryToUpdate);

            return Unit.Value;
        }
    }
}