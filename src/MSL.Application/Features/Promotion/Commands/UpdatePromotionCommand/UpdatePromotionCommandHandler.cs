using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Promotion.Commands.UpdatePromotionCommand
{
    public class UpdatePromotionCommandHandler : IRequestHandler<UpdatePromotionCommand, Unit>
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly IMapper _mapper;

        public UpdatePromotionCommandHandler(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePromotionCommand request, CancellationToken cancellationToken)
        {
            var promotionToUpdate = _mapper.Map<Domain.Promotion>(request);
            await _promotionRepository.Update(promotionToUpdate);

            return Unit.Value;
        }
    }
}