using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Review;

namespace MLS.Application.Features.Review.Queries.GetAllReview
{
    public class GetAllReviewQueryHandler : IRequestHandler<GetAllReviewQuery, List<ReviewDto>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public GetAllReviewQueryHandler(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<List<ReviewDto>> Handle(GetAllReviewQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _reviewRepository.GetAll();
            var data = _mapper.Map<List<ReviewDto>>(reviews);

            return data;
        }
    }
}