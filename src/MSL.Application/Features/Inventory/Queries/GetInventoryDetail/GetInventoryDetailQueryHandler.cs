using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Inventory;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Inventory.Queries.GetInventoryDetail
{
    public class GetInventoryDetailQueryHandler : IRequestHandler<GetInventoryDetailQuery, InventoryDetailDto>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetInventoryDetailQueryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public async Task<InventoryDetailDto> Handle(GetInventoryDetailQuery request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.GetById(request.Id);

            if (inventory == null)
            {
                throw new NotFoundException(nameof(Domain.Inventory), request.Id);
            }

            var data = _mapper.Map<InventoryDetailDto>(inventory);

            return data;
        }
    }
}