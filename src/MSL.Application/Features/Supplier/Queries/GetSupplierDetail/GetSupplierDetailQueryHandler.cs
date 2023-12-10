using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Supplier;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Supplier.Queries.GetSupplierDetail
{
    public class GetSupplierDetailQueryHandler : IRequestHandler<GetSupplierDetailQuery, SupplierDetailDto>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public GetSupplierDetailQueryHandler(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<SupplierDetailDto> Handle(GetSupplierDetailQuery request, CancellationToken cancellationToken)
        {
            var supplier = await _supplierRepository.GetById(request.Id);

            if (supplier == null)
            {
                throw new NotFoundException(nameof(Domain.Supplier), request.Id);
            }

            var data = _mapper.Map<SupplierDetailDto>(supplier);

            return data;
        }
    }
}