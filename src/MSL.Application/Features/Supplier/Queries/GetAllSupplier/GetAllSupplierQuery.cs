using MediatR;
using MLS.Application.DTO.Supplier;

namespace MLS.Application.Features.Supplier.Queries.GetAllSupplier
{
    public record GetAllSupplierQuery : IRequest<List<SupplierDto>>;
}