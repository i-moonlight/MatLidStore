using MediatR;

namespace MLS.Application.Features.ShoppingCart.Commands.DeleteShoppingCartCommand
{
    public class DeleteShoppingCartCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}