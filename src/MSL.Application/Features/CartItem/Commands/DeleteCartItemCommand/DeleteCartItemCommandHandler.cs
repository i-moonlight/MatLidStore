using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.CartItem.Commands.DeleteCartItemCommand
{
    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, Unit>
    {
        private readonly ICartItemRepository _cartItemRepository;

        public DeleteCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<Unit> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItemToDelete = await _cartItemRepository.GetById(request.Id);

            if (cartItemToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.CartItem), request.Id);
            }

            await _cartItemRepository.Delete(cartItemToDelete);

            return Unit.Value;
        }
    }
}