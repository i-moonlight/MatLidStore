using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Review;
using MLS.Application.Exceptions;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Queries.GetReviewFeedbackDetail
{
    public class GetReviewFeedbackDetailQueryHandler : IRequestHandler<GetReviewFeedbackDetailQuery, ReviewFeedbackDetailDto>
    {
        private readonly IReviewFeedbackRepository _reviewFeedbackRepository;
        private readonly IMapper _mapper;

        public GetReviewFeedbackDetailQueryHandler(IReviewFeedbackRepository reviewFeedbackRepository, IMapper mapper)
        {
            _reviewFeedbackRepository = reviewFeedbackRepository;
            _mapper = mapper;
        }

        public async Task<ReviewFeedbackDetailDto> Handle(GetReviewFeedbackDetailQuery request, CancellationToken cancellationToken)
        {
            var reviewFeedback = await _reviewFeedbackRepository.GetById(request.Id);

            if (reviewFeedback == null)
            {
                throw new NotFoundException(nameof(ReviewFeedback), request.Id);
            }

            var data = _mapper.Map<ReviewFeedbackDetailDto>(reviewFeedback);

            return data;
        }
    }
}