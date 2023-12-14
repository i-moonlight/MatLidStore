using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Promotion.Commands.CreatePromotionCommand
{
    public class CreatePromotionCommandHandler : IRequestHandler<CreatePromotionCommand, int>
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly IMapper _mapper;

        public CreatePromotionCommandHandler(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePromotionCommand request, CancellationToken cancellationToken)
        {
            var promotionToCreate = _mapper.Map<Domain.Promotion>(request);
            await _promotionRepository.Create(promotionToCreate);

            return promotionToCreate.Id;
        }
    }
}