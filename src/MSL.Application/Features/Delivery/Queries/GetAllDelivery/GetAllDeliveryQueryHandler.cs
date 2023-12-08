using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Delivery.Queries.GetAllDelivery
{
    public class GetAllDeliveryQueryHandler : IRequestHandler<GetAllDeliveryQuery, List<DeliveryDto>>
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public GetAllDeliveryQueryHandler(IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public async Task<List<DeliveryDto>> Handle(GetAllDeliveryQuery request, CancellationToken cancellationToken)
        {
            var deliveries = await _deliveryRepository.GetAll();
            var data = _mapper.Map<List<DeliveryDto>>(deliveries);

            return data;
        }
    }
}
