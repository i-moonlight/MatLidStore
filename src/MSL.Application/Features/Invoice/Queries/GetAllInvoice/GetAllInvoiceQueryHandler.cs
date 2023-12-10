using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Invoice;

namespace MLS.Application.Features.Invoice.Queries.GetAllInvoice
{
    public class GetAllInvoiceQueryHandler : IRequestHandler<GetAllInvoiceQuery, List<InvoiceDto>>
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public GetAllInvoiceQueryHandler(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }

        public async Task<List<InvoiceDto>> Handle(GetAllInvoiceQuery request, CancellationToken cancellationToken)
        {
            var invoices = await _invoiceRepository.GetAll();
            var data = _mapper.Map<List<InvoiceDto>>(request);

            return data;
        }
    }
}