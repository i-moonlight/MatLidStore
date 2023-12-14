using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Inventory.Commands.DeleteInventoryCommand
{
    public class DeleteInventoryCommandHandler : IRequestHandler<DeleteInventoryCommand, Unit>
    {
        private readonly IInventoryRepository _inventoryRepository;

        public DeleteInventoryCommandHandler(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<Unit> Handle(DeleteInventoryCommand request, CancellationToken cancellationToken)
        {
            var inventoryToDelete = await _inventoryRepository.GetById(request.Id);

            if (inventoryToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Inventory), request.Id);
            }

            await _inventoryRepository.Delete(inventoryToDelete);

            return Unit.Value;
        }
    }
}