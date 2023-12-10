using MediatR;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetAllProduct
{
    public record GetAllProductQuery : IRequest<List<ProductDto>>;
}