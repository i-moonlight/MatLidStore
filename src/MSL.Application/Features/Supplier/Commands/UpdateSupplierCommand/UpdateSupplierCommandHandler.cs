using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Supplier.Commands.UpdateSupplierCommand
{
    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, Unit>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public UpdateSupplierCommandHandler(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplierToUpdate = _mapper.Map<Domain.Supplier>(request);
            await _supplierRepository.Update(supplierToUpdate);

            return Unit.Value;
        }
    }
}