using MediatR;

namespace MLS.Application.Features.Inventory.Commands.DeleteInventoryCommand
{
    public class DeleteInventoryCommand : IRequest<Unit>
    {
        public int InventoryId { get; set; }
    }
}