using MediatR;
using MLS.Application.DTO.Product;

namespace MLS.Application.Features.Product.Queries.GetProductSupplierDetail
{
    public record GetProductSupplierDetailQuery(int Id) : IRequest<ProductSupplierDetailDto>;
}