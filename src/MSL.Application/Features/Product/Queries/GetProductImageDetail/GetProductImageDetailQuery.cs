using MediatR;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetProductImageDetail;

public record GetProductImageDetailQuery(int Id) : IRequest<ProductImageDetailDto>;