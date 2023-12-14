using MediatR;

namespace MLS.Application.Features.WishList.Commands.DeleteWishListCommand
{
    public class DeleteWishListCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}