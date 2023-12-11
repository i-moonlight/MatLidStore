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

namespace MLS.Application.Features.Order.Queries.GetOrderHistoryDetail
{
    public class GetOrderHistoryDetailQueryHandler : IRequestHandler<GetOrderHistoryDetailQuery, OrderHistoryDetailDto>
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IMapper _mapper;

        public GetOrderHistoryDetailQueryHandler(IOrderHistoryRepository orderHistoryRepository, IMapper mapper)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _mapper = mapper;
        }

        public async Task<OrderHistoryDetailDto> Handle(GetOrderHistoryDetailQuery request, CancellationToken cancellationToken)
        {
            var orderHistory = await _orderHistoryRepository.GetById(request.Id);

            if (orderHistory == null)
            {
                throw new NotFoundException(nameof(Domain.OrderHistory), request.Id);
            }

            var data = _mapper.Map<OrderHistoryDetailDto>(orderHistory);

            return data;
        }
    }
}