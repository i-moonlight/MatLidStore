using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Invoice.Commands.DeleteInvoiceCommand
{
    public class DeleteInvoiceCommandHandler : IRequestHandler<DeleteInvoiceCommand, Unit>
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public DeleteInvoiceCommandHandler(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<Unit> Handle(DeleteInvoiceCommand request, CancellationToken cancellationToken)
        {
            var invoiceToDelete = await _invoiceRepository.GetById(request.Id);

            if (invoiceToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Invoice), request.Id);
            }

            await _invoiceRepository.Delete(invoiceToDelete);

            return Unit.Value;
        }
    }
}