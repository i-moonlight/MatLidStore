using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetAllOrderHistory
{
    public class GetAllOrderHistoryQueryHandler : IRequestHandler<GetAllOrderHistoryQuery, List<OrderHistoryDto>>
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IMapper _mapper;

        public GetAllOrderHistoryQueryHandler(IOrderHistoryRepository orderHistoryRepository, IMapper mapper)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderHistoryDto>> Handle(GetAllOrderHistoryQuery request, CancellationToken cancellationToken)
        {
            var orderHistories = await _orderHistoryRepository.GetAll();
            var data = _mapper.Map<List<OrderHistoryDto>>(orderHistories);

            return data;
        }
    }
}
