using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetAllOrderItem
{
    public class GetAllOrderItemQueryHandler : IRequestHandler<GetAllOrderItemQuery, List<OrderItemDto>>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public GetAllOrderItemQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderItemDto>> Handle(GetAllOrderItemQuery request, CancellationToken cancellationToken)
        {
            var orderItems = await _orderItemRepository.GetAll();
            var data = _mapper.Map<List<OrderItemDto>>(orderItems);

            return data;
        }
    }
}
