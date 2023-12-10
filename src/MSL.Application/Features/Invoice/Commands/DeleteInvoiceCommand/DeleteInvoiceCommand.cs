using MediatR;

namespace MLS.Application.Features.Invoice.Commands.DeleteInvoiceCommand
{
    public class DeleteInvoiceCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}