using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Supplier.Commands.DeleteSupplierCommand
{
    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand, Unit>
    {
        private readonly ISupplierRepository _supplierRepository;

        public DeleteSupplierCommandHandler(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<Unit> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplierToDelete = await _supplierRepository.GetById(request.Id);

            if (supplierToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Supplier), request.Id);
            }

            await _supplierRepository.Delete(supplierToDelete);

            return Unit.Value;
        }
    }
}