using MediatR;

namespace MLS.Application.Features.CartItem.Commands.DeleteCartItemCommand
{
    public class DeleteCartItemCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}