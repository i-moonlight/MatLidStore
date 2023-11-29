using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var cartItemToDelete = await _cartItemRepository.GetById(request.CartItemId);

            if (cartItemToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.CartItem), request.CartItemId);
            }

            await _cartItemRepository.Delete(cartItemToDelete);

            return Unit.Value;
        }
    }
}