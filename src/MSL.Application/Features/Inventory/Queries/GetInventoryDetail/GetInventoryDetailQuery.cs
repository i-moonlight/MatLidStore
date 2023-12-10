using MediatR;
using MLS.Application.DTO.Inventory;

namespace MLS.Application.Features.Inventory.Queries.GetInventoryDetail
{
    public record GetInventoryDetailQuery(int Id) : IRequest<InventoryDetailDto>;
}