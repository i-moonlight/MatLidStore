using MediatR;
using MLS.Application.DTO.Coupon;

namespace MLS.Application.Features.Coupon.Queries.GetCouponDetail
{
    public record GetCouponDetailQuery(int Id) : IRequest<CouponDetailDto>;
}