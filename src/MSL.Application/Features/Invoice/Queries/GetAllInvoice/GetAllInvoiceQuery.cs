using MediatR;
using MLS.Application.DTO.Invoice;

namespace MLS.Application.Features.Invoice.Queries.GetAllInvoice
{
    public record GetAllInvoiceQuery : IRequest<List<InvoiceDto>>;
}