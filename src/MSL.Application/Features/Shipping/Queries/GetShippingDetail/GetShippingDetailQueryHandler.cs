using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Shipping;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Shipping.Queries.GetShippingDetail
{
    public class GetShippingDetailQueryHandler : IRequestHandler<GetShippingDetailQuery, ShippingDetailDto>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public GetShippingDetailQueryHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<ShippingDetailDto> Handle(GetShippingDetailQuery request, CancellationToken cancellationToken)
        {
            var shipping = await _shippingRepository.GetById(request.Id);

            if (shipping == null)
            {
                throw new NotFoundException(nameof(Domain.Shipping), request.Id);
            }

            var data = _mapper.Map<ShippingDetailDto>(shipping);

            return data;
        }
    }
}