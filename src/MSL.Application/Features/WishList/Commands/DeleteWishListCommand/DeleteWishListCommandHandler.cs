using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.WishList.Commands.DeleteWishListCommand
{
    public class DeleteWishListCommandHandler : IRequestHandler<DeleteWishListCommand, Unit>
    {
        private readonly IWishListRepository _wishListRepository;

        public DeleteWishListCommandHandler(IWishListRepository wishListRepository)
        {
            _wishListRepository = wishListRepository;
        }

        public async Task<Unit> Handle(DeleteWishListCommand request, CancellationToken cancellationToken)
        {
            var wishListToDelete = await _wishListRepository.GetById(request.Id);
            if (wishListToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.WishList), request.Id);
            }

            await _wishListRepository.Delete(wishListToDelete);

            return Unit.Value;
        }
    }
}