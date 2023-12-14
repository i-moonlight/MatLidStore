using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Product;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Product.Queries.GetProductSupplierDetail
{
    public class GetProductSupplierDetailQueryHandler : IRequestHandler<GetProductSupplierDetailQuery, ProductSupplierDetailDto>
    {
        private readonly IProductSupplierRepository _productSupplierRepository;
        private readonly IMapper _mapper;

        public GetProductSupplierDetailQueryHandler(IProductSupplierRepository productSupplierRepository, IMapper mapper)
        {
            _productSupplierRepository = productSupplierRepository;
            _mapper = mapper;
        }

        public async Task<ProductSupplierDetailDto> Handle(GetProductSupplierDetailQuery request, CancellationToken cancellationToken)
        {
            var productSupplier = await _productSupplierRepository.GetById(request.Id);

            if (productSupplier == null)
            {
                throw new NotFoundException(nameof(Domain.ProductSupplier), request.Id);
            }

            var data = _mapper.Map<ProductSupplierDetailDto>(productSupplier);

            return data;
        }
    }
}