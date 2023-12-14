using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetAllProductImage
{
    public class GetAllProductImageQueryHandler : IRequestHandler<GetAllProductImageQuery, List<ProductImageDto>>
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;

        public GetAllProductImageQueryHandler(IProductImageRepository productImageRepository, IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductImageDto>> Handle(GetAllProductImageQuery request, CancellationToken cancellationToken)
        {
            var productImages = await _productImageRepository.GetAll();
            var data = _mapper.Map<List<ProductImageDto>>(productImages);

            return data;
        }
    }
}