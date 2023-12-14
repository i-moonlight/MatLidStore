using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Order;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetOrderItemDetail
{
    public class GetOrderItemDetailQueryHandler : IRequestHandler<GetOrderItemDetailQuery, OrderItemDetailDto>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public GetOrderItemDetailQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public async Task<OrderItemDetailDto> Handle(GetOrderItemDetailQuery request, CancellationToken cancellationToken)
        {
            var orderItem = await _orderItemRepository.GetById(request.Id);

            if (orderItem == null)
            {
                throw new NotFoundException(nameof(Domain.OrderItem), request.Id);
            }

            var data = _mapper.Map<OrderItemDetailDto>(orderItem);

            return data;
        }
    }
}