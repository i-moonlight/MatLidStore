using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Address;

namespace MLS.Application.Features.Address.Queries.GetAllAddress
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQuery, List<AddressDto>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAllAddressQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<List<AddressDto>> Handle(GetAllAddressQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetAll();
            var data = _mapper.Map<List<AddressDto>>(addresses);

            return data;
        }
    }
}