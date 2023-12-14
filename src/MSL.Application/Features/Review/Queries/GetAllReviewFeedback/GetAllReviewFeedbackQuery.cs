﻿using MediatR;
using MLS.Application.DTO.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Review.Queries.GetAllReviewFeedback
{
    public record GetAllReviewFeedbackQuery : IRequest<List<ReviewFeedbackDto>>;
}
