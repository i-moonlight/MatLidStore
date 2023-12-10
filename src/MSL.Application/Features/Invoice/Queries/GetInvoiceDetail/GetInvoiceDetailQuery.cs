using MediatR;
using MLS.Application.DTO.Invoice;

namespace MLS.Application.Features.Invoice.Queries.GetInvoiceDetail
{
    public record GetInvoiceDetailQuery(int Id) : IRequest<InvoiceDetailDto>;
}