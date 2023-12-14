using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Product;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Product.Queries.GetProductImageDetail;

public class GetProductImageDetailQueryHandler : IRequestHandler<GetProductImageDetailQuery, ProductImageDetailDto>
{
    private readonly IProductImageRepository _productImageRepository;
    private readonly IMapper _mapper;

    public GetProductImageDetailQueryHandler(IProductImageRepository productImageRepository, IMapper mapper)
    {
        _productImageRepository = productImageRepository;
        _mapper = mapper;
    }

    public async Task<ProductImageDetailDto> Handle(GetProductImageDetailQuery request, CancellationToken cancellationToken)
    {
        var productImage = await _productImageRepository.GetById(request.Id);

        if (productImage == null)
            throw new NotFoundException(nameof(Domain.ProductImage), request.Id);

        var data = _mapper.Map<ProductImageDetailDto>(productImage);

        return data;
    }
}