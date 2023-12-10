using MediatR;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetProductDetail
{
    public record GetProductDetailQuery(int Id) : IRequest<ProductDetailDto>;
}