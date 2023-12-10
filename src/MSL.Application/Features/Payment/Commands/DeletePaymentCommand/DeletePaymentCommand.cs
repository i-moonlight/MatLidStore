using MediatR;

namespace MLS.Application.Features.Payment.Commands.DeletePaymentCommand
{
    public class DeletePaymentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}