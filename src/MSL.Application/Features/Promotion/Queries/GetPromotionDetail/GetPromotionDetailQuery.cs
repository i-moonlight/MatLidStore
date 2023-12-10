using MediatR;
using MLS.Application.DTO.Promotion;

namespace MLS.Application.Features.Promotion.Queries.GetPromotionDetail
{
    public record GetPromotionDetailQuery(int Id) : IRequest<PromotionDetailDto>;
}