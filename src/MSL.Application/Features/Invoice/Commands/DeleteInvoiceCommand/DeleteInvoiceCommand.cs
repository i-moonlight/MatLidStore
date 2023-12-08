using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Invoice.Commands.DeleteInvoiceCommand
{
    public class DeleteInvoiceCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
