using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Inventory;

namespace MLS.Application.Features.Inventory.Queries.GetAllInventory
{
    public class GetAllInventoryQueryHandler : IRequestHandler<GetAllInventoryQuery, List<InventoryDto>>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetAllInventoryQueryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public async Task<List<InventoryDto>> Handle(GetAllInventoryQuery request, CancellationToken cancellationToken)
        {
            var inventories = await _inventoryRepository.GetAll();
            var data = _mapper.Map<List<InventoryDto>>(inventories);

            return data;
        }
    }
}