using MediatR;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetAllProductSupplier
{
    public record GetAllProductSupplierQuery : IRequest<List<ProductSupplierDto>>;
}