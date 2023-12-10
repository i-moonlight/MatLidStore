using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Coupon.Commands.DeleteCouponCommand
{
    public class DeleteCouponCommandHandler : IRequestHandler<DeleteCouponCommand, Unit>
    {
        private readonly ICouponRepository _couponRepository;

        public DeleteCouponCommandHandler(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        public async Task<Unit> Handle(DeleteCouponCommand request, CancellationToken cancellationToken)
        {
            var couponToDelete = await _couponRepository.GetById(request.Id);

            if (couponToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Coupon), request.Id);
            }

            await _couponRepository.Delete(couponToDelete);

            return Unit.Value;
        }
    }
}