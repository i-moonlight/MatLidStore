using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Address;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Address.Queries.GetAddressDetail
{
    public class GetAddressDetailQueryHandler : IRequestHandler<GetAddressDetailQuery, AddressDetailDto>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressDetailQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<AddressDetailDto> Handle(GetAddressDetailQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetById(request.Id);

            if (address == null)
            {
                throw new NotFoundException(nameof(Domain.Address), request.Id);
            }

            var data = _mapper.Map<AddressDetailDto>(address);

            return data;
        }
    }
}