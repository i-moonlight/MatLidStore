using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.ShoppingCart.Commands.DeleteShoppingCartCommand
{
    public class DeleteShoppingCartCommandHandler : IRequestHandler<DeleteShoppingCartCommand, Unit>
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public DeleteShoppingCartCommandHandler(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public async Task<Unit> Handle(DeleteShoppingCartCommand request, CancellationToken cancellationToken)
        {
            var shoppingCartToDelete = await _shoppingCartRepository.GetById(request.Id);

            if (shoppingCartToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.ShoppingCart), request.Id);
            }

            await _shoppingCartRepository.Delete(shoppingCartToDelete);

            return Unit.Value;
        }
    }
}