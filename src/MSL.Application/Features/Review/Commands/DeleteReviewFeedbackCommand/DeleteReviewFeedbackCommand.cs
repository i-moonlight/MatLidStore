using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Commands.DeleteReviewFeedbackCommand
{
    public class DeleteReviewFeedbackCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
