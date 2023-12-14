using MediatR;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetAllProductImage
{
    public record GetAllProductImageQuery : IRequest<List<ProductImageDto>>;
}