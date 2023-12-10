using MediatR;

namespace MLS.Application.Features.Review.Commands.DeleteReviewCommand
{
    public class DeleteReviewCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}