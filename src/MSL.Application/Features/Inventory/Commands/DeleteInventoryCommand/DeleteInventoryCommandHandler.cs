using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var inventoryToDelete = await _inventoryRepository.GetById(request.InventoryId);

            if (inventoryToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Inventory), request.InventoryId);
            }

            await _inventoryRepository.Delete(inventoryToDelete);

            return Unit.Value;
        }
    }
}
