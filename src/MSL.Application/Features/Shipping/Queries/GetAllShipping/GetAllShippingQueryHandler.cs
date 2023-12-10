using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Shipping;

namespace MLS.Application.Features.Shipping.Queries.GetAllShipping
{
    public class GetAllShippingQueryHandler : IRequestHandler<GetAllShippingQuery, List<ShippingDto>>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public GetAllShippingQueryHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<List<ShippingDto>> Handle(GetAllShippingQuery request, CancellationToken cancellationToken)
        {
            var shippings = await _shippingRepository.GetAll();
            var data = _mapper.Map<List<ShippingDto>>(shippings);

            return data;
        }
    }
}