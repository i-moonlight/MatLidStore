using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Invoice.Commands.UpdateInvoiceCommand
{
    public class UpdateInvoiceCommandHandler : IRequestHandler<UpdateInvoiceCommand, Unit>
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public UpdateInvoiceCommandHandler(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateInvoiceCommand request, CancellationToken cancellationToken)
        {
            var invoiceToUpdate = _mapper.Map<Domain.Invoice>(request);
            await _invoiceRepository.Update(invoiceToUpdate);

            return Unit.Value;
        }
    }
}