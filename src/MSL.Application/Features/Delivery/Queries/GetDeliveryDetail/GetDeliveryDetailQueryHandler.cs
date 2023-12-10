using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Delivery;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Delivery.Queries.GetDeliveryDetail
{
    public class GetDeliveryDetailQueryHandler : IRequestHandler<GetDeliveryDetailQuery, DeliveryDetailDto>
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public GetDeliveryDetailQueryHandler(IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public async Task<DeliveryDetailDto> Handle(GetDeliveryDetailQuery request, CancellationToken cancellationToken)
        {
            var delivery = await _deliveryRepository.GetById(request.Id);

            if (delivery == null)
            {
                throw new NotFoundException(nameof(Domain.Delivery), request.Id);
            }

            var data = _mapper.Map<DeliveryDetailDto>(delivery);

            return data;
        }
    }
}