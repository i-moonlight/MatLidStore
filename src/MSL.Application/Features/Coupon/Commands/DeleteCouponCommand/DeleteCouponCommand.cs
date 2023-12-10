using MediatR;

namespace MLS.Application.Features.Coupon.Commands.DeleteCouponCommand
{
    public class DeleteCouponCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}