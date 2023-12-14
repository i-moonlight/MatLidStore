using MediatR;

namespace MLS.Application.Features.Order.Commands.DeleteOrderItemCommand
{
    public class DeleteOrderItemCommand : IRequest<Unit>
    {
        public int OrderItemId { get; set; }
    }
}