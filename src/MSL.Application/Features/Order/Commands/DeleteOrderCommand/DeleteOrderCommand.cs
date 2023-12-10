using MediatR;

namespace MLS.Application.Features.Order.Commands.DeleteOrderCommand
{
    public class DeleteOrderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}