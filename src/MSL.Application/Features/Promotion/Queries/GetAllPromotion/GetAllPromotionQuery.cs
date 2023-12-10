using MediatR;
using MLS.Application.DTO.Promotion;

namespace MLS.Application.Features.Promotion.Queries.GetAllPromotion
{
    public record GetAllPromotionQuery : IRequest<List<PromotionDto>>;
}