using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Supplier;

namespace MLS.Application.Features.Supplier.Queries.GetAllSupplier
{
    public class GetAllSupplierQueryHandler : IRequestHandler<GetAllSupplierQuery, List<SupplierDto>>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public GetAllSupplierQueryHandler(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<List<SupplierDto>> Handle(GetAllSupplierQuery request, CancellationToken cancellationToken)
        {
            var suppliers = await _supplierRepository.GetAll();
            var data = _mapper.Map<List<SupplierDto>>(suppliers);

            return data;
        }
    }
}