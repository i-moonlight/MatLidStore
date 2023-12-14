using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Queries.GetAllReviewFeedback
{
    public class GetAllReviewFeedbackQueryHandler : IRequestHandler<GetAllReviewFeedbackQuery, List<ReviewFeedbackDto>>
    {
        private readonly IReviewFeedbackRepository _reviewFeedbackRepository;
        private readonly IMapper _mapper;

        public GetAllReviewFeedbackQueryHandler(IReviewFeedbackRepository reviewFeedbackRepository, IMapper mapper)
        {
            _reviewFeedbackRepository = reviewFeedbackRepository;
            _mapper = mapper;
        }

        public async Task<List<ReviewFeedbackDto>> Handle(GetAllReviewFeedbackQuery request, CancellationToken cancellationToken)
        {
            var reviewFeedbacks = await _reviewFeedbackRepository.GetAll();
            var data = _mapper.Map<List<ReviewFeedbackDto>>(reviewFeedbacks);

            return data;
        }
    }
}