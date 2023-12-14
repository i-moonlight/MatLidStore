using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Commands.DeleteReviewFeedbackCommand
{
    public class DeleteReviewFeedbackCommandHandler : IRequestHandler<DeleteReviewFeedbackCommand, Unit>
    {
        private readonly IReviewFeedbackRepository _reviewFeedbackRepository;

        public DeleteReviewFeedbackCommandHandler(IReviewFeedbackRepository reviewFeedbackRepository)
        {
            _reviewFeedbackRepository = reviewFeedbackRepository;
        }

        public async Task<Unit> Handle(DeleteReviewFeedbackCommand request, CancellationToken cancellationToken)
        {
            var reviewFeedbackToDelete = await _reviewFeedbackRepository.GetById(request.Id);

            if (reviewFeedbackToDelete == null)
            {
                throw new NotFoundException(nameof(ReviewFeedback), request.Id);
            }

            await _reviewFeedbackRepository.Delete(reviewFeedbackToDelete);

            return Unit.Value;
        }
    }
}