using MediatR;
using MLS.Application.DTO.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Coupon.Queries.GetAllCoupon
{
    public record GetAllCouponQuery : IRequest<List<CouponDto>>;
}
