using MediatR;

namespace MLS.Application.Features.Shipping.Commands.DeleteShippingCommand
{
    public class DeleteShippingCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}