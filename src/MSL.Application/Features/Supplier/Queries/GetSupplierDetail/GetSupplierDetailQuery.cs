using MediatR;
using MLS.Application.DTO.Supplier;

namespace MLS.Application.Features.Supplier.Queries.GetSupplierDetail
{
    public record GetSupplierDetailQuery(int Id) : IRequest<SupplierDetailDto>;
}