using MediatR;
using MLS.Application.DTO.Coupon;

namespace MLS.Application.Features.Coupon.Queries.GetAllCoupon
{
    public record GetAllCouponQuery : IRequest<List<CouponDto>>;
}