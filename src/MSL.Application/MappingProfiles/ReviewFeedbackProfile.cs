using AutoMapper;
using MLS.Application.DTO.Review;
using MLS.Application.Features.Review.Commands.CreateReviewFeedbackCommand;
using MLS.Application.Features.Review.Commands.DeleteReviewFeedbackCommand;
using MLS.Application.Features.Review.Commands.UpdateReviewFeedbackCommand;
using MLS.Domain;

namespace MLS.Application.MappingProfiles
{
    public class ReviewFeedbackProfile : Profile
    {
        public ReviewFeedbackProfile()
        {
            CreateMap<ReviewFeedbackDto, ReviewFeedback>().ReverseMap();
            CreateMap<ReviewFeedback, ReviewFeedbackDetailDto>();
            CreateMap<ReviewFeedback, CreateReviewFeedbackCommand>();
            CreateMap<ReviewFeedback, UpdateReviewFeedbackCommand>();
            CreateMap<ReviewFeedback, DeleteReviewFeedbackCommand>();
        }
    }
}