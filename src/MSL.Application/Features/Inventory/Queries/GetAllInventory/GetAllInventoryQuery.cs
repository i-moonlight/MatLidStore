using MediatR;
using MLS.Application.DTO.Inventory;

namespace MLS.Application.Features.Inventory.Queries.GetAllInventory
{
    public record GetAllInventoryQuery : IRequest<List<InventoryDto>>;
}