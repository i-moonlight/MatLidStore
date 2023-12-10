using MediatR;
using MLS.Application.DTO.Review;

namespace MLS.Application.Features.Review.Queries.GetReviewDetail
{
    public record GetReviewDetailQuery(int Id) : IRequest<ReviewDetailDto>;
}