using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Coupon.Queries.GetAllCoupon
{
    public class GetAllCouponQueryHandler : IRequestHandler<GetAllCouponQuery, List<CouponDto>>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public GetAllCouponQueryHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<List<CouponDto>> Handle(GetAllCouponQuery request, CancellationToken cancellationToken)
        {
            var coupons = await _couponRepository.GetAll();
            var data = _mapper.Map<List<CouponDto>>(coupons);

            return data;
        }
    }
}
