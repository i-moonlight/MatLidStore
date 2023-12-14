using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Commands.CreateReviewFeedbackCommand
{
    public class CreateReviewFeedbackCommandHandler : IRequestHandler<CreateReviewFeedbackCommand, int>
    {
        private readonly IReviewFeedbackRepository _reviewFeedbackRepository;
        private readonly IMapper _mapper;

        public CreateReviewFeedbackCommandHandler(IReviewFeedbackRepository reviewFeedbackRepository, IMapper mapper)
        {
            _reviewFeedbackRepository = reviewFeedbackRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateReviewFeedbackCommand request, CancellationToken cancellationToken)
        {
            var reviewFeedbackToCreate = _mapper.Map<ReviewFeedback>(request);
            await _reviewFeedbackRepository.Create(reviewFeedbackToCreate);

            return reviewFeedbackToCreate.Id;
        }
    }
}
