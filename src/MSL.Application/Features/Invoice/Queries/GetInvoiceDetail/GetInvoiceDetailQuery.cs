using MediatR;
using MLS.Application.DTO.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Invoice.Queries.GetInvoiceDetail
{
    public record GetInvoiceDetailQuery(int Id) : IRequest<InvoiceDetailDto>;
}
