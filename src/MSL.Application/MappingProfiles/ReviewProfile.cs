using AutoMapper;
using MLS.Application.DTO.Review;
using MLS.Application.Features.Review.Commands.CreateReviewCommand;
using MLS.Application.Features.Review.Commands.DeleteReviewCommand;
using MLS.Application.Features.Review.Commands.UpdateReviewCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewDto, Review>().ReverseMap();
            CreateMap<Review, ReviewDetailDto>();
            CreateMap<Review, CreateReviewCommand>();
            CreateMap<Review, UpdateReviewCommand>();
            CreateMap<Review, DeleteReviewCommand>();
        }
    }
}
