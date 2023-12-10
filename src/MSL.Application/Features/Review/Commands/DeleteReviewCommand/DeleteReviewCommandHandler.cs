using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Review.Commands.DeleteReviewCommand
{
    public class DeleteReviewCommandHandler : IRequestHandler<DeleteReviewCommand, Unit>
    {
        private readonly IReviewRepository _reviewRepository;

        public DeleteReviewCommandHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Unit> Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
        {
            var reviewToDelete = await _reviewRepository.GetById(request.Id);

            if (reviewToDelete == null)
                throw new NotFoundException(nameof(Domain.Review), request.Id);

            await _reviewRepository.Delete(reviewToDelete);

            return Unit.Value;
        }
    }
}