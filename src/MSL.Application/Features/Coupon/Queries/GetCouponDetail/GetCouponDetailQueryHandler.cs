using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Coupon;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Coupon.Queries.GetCouponDetail
{
    public class GetCouponDetailQueryHandler : IRequestHandler<GetCouponDetailQuery, CouponDetailDto>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public GetCouponDetailQueryHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<CouponDetailDto> Handle(GetCouponDetailQuery request, CancellationToken cancellationToken)
        {
            var coupon = await _couponRepository.GetById(request.Id);

            if (coupon == null)
            {
                throw new NotFoundException(nameof(Domain.Coupon), request.Id);
            }

            var data = _mapper.Map<CouponDetailDto>(coupon);

            return data;
        }
    }
}