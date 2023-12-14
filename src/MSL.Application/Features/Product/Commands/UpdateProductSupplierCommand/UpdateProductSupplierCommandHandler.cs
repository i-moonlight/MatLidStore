using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Commands.UpdateProductSupplierCommand
{
    public class UpdateProductSupplierCommandHandler : IRequestHandler<UpdateProductSupplierCommand, Unit>
    {
        private readonly IProductSupplierRepository _productSupplierRepository;
        private readonly IMapper _mapper;

        public UpdateProductSupplierCommandHandler(IProductSupplierRepository productSupplierRepository, IMapper mapper)
        {
            _productSupplierRepository = productSupplierRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductSupplierCommand request, CancellationToken cancellationToken)
        {
            var productSupplierToUpdate = _mapper.Map<Domain.ProductSupplier>(request);
            await _productSupplierRepository.Update(productSupplierToUpdate);

            return Unit.Value;
        }
    }
}
