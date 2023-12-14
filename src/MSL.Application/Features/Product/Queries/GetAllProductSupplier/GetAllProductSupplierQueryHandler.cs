using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetAllProductSupplier
{
    public class GetAllProductSupplierQueryHandler : IRequestHandler<GetAllProductSupplierQuery, List<ProductSupplierDto>>
    {
        private readonly IProductSupplierRepository _psrProductSupplierRepository;
        private readonly IMapper _mapper;

        public GetAllProductSupplierQueryHandler(IProductSupplierRepository psrProductSupplierRepository, IMapper mapper)
        {
            _psrProductSupplierRepository = psrProductSupplierRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductSupplierDto>> Handle(GetAllProductSupplierQuery request, CancellationToken cancellationToken)
        {
            var productSuppliers = await _psrProductSupplierRepository.GetAll();
            var data = _mapper.Map<List<ProductSupplierDto>>(productSuppliers);

            return data;
        }
    }
}