using MediatR;

namespace MLS.Application.Features.Delivery.Commands.DeleteDeliveryCommand
{
    public class DeleteDeliveryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}