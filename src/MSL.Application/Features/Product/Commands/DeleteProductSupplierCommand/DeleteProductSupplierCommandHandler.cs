using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Commands.DeleteProductSupplierCommand
{
    public class DeleteProductSupplierCommandHandler : IRequestHandler<DeleteProductSupplierCommand, Unit>
    {
        private readonly IProductSupplierRepository _productSupplierRepository;

        public DeleteProductSupplierCommandHandler(IProductSupplierRepository productSupplierRepository)
        {
            _productSupplierRepository = productSupplierRepository;
        }

        public async Task<Unit> Handle(DeleteProductSupplierCommand request, CancellationToken cancellationToken)
        {
            var productSupplierToDelete = await _productSupplierRepository.GetById(request.Id);

            if (productSupplierToDelete == null)
                throw new NotFoundException(nameof(Domain.ProductSupplier), request.Id);

            await _productSupplierRepository.Delete(productSupplierToDelete);

            return Unit.Value;
        }
    }
}