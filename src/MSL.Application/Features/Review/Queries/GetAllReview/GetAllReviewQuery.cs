using MediatR;
using MLS.Application.DTO.Review;

namespace MLS.Application.Features.Review.Queries.GetAllReview
{
    public record GetAllReviewQuery : IRequest<List<ReviewDto>>;
}