using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Review;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Review.Queries.GetReviewDetail
{
    public class GetReviewDetailQueryHandler : IRequestHandler<GetReviewDetailQuery, ReviewDetailDto>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public GetReviewDetailQueryHandler(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<ReviewDetailDto> Handle(GetReviewDetailQuery request, CancellationToken cancellationToken)
        {
            var review = await _reviewRepository.GetById(request.Id);

            if (review == null)
            {
                throw new NotFoundException(nameof(Domain.Review), request.Id);
            }

            var data = _mapper.Map<ReviewDetailDto>(review);

            return data;
        }
    }
}