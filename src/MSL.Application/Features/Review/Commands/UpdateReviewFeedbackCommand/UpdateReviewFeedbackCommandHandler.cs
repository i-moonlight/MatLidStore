using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Commands.UpdateReviewFeedbackCommand
{
    public class UpdateReviewFeedbackCommandHandler : IRequestHandler<UpdateReviewFeedbackCommand, Unit>
    {
        private readonly IReviewFeedbackRepository _reviewFeedbackRepository;
        private readonly IMapper _mapper;

        public UpdateReviewFeedbackCommandHandler(IReviewFeedbackRepository reviewFeedbackRepository, IMapper mapper)
        {
            _reviewFeedbackRepository = reviewFeedbackRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReviewFeedbackCommand request, CancellationToken cancellationToken)
        {
            var reviewFeedbackToUpdate = _mapper.Map<ReviewFeedback>(request);
            await _reviewFeedbackRepository.Update(reviewFeedbackToUpdate);

            return Unit.Value;
        }
    }
}