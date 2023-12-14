using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Promotion.Commands.DeletePromotionCommand
{
    public class DeletePromotionCommandHandler : IRequestHandler<DeletePromotionCommand, Unit>
    {
        private readonly IPromotionRepository _promotionRepository;

        public DeletePromotionCommandHandler(IPromotionRepository promotionRepository)
        {
            _promotionRepository = promotionRepository;
        }

        public async Task<Unit> Handle(DeletePromotionCommand request, CancellationToken cancellationToken)
        {
            var promotionToDelete = await _promotionRepository.GetById(request.Id);

            if (promotionToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Promotion), request.Id);
            }

            await _promotionRepository.Delete(promotionToDelete);

            return Unit.Value;
        }
    }
}