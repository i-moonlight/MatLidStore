using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Commands.CreateProductSupplierCommand
{
    public class CreateProductSupplierCommandHandler : IRequestHandler<CreateProductSupplierCommand, int>
    {
        private readonly IProductSupplierRepository _productSupplierRepository;
        private readonly IMapper _mapper;

        public CreateProductSupplierCommandHandler(IProductSupplierRepository productSupplierRepository, IMapper mapper)
        {
            _productSupplierRepository = productSupplierRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductSupplierCommand request, CancellationToken cancellationToken)
        {
            var productSupplierToCreate = _mapper.Map<ProductSupplier>(request);
            await _productSupplierRepository.Create(productSupplierToCreate);

            return productSupplierToCreate.Id;
        }
    }
}
