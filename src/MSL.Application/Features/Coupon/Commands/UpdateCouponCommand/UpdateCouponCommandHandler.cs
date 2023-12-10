using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Coupon.Commands.UpdateCouponCommand
{
    public class UpdateCouponCommandHandler : IRequestHandler<UpdateCouponCommand, Unit>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public UpdateCouponCommandHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCouponCommand request, CancellationToken cancellationToken)
        {
            var couponToUpdate = _mapper.Map<Domain.Coupon>(request);
            await _couponRepository.Update(couponToUpdate);

            return Unit.Value;
        }
    }
}