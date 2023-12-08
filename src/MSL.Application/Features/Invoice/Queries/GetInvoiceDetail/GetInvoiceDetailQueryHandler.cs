using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Invoice;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Invoice.Queries.GetInvoiceDetail
{
    public class GetInvoiceDetailQueryHandler : IRequestHandler<GetInvoiceDetailQuery, InvoiceDetailDto>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetInvoiceDetailQueryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public async Task<InvoiceDetailDto> Handle(GetInvoiceDetailQuery request, CancellationToken cancellationToken)
        {
            var invoice = await _inventoryRepository.GetById(request.Id);

            if (invoice == null)
            {
                throw new NotFoundException(nameof(Domain.Invoice), request.Id);
            }

            var data = _mapper.Map<InvoiceDetailDto>(invoice);

            return data;
        }
    }
}
