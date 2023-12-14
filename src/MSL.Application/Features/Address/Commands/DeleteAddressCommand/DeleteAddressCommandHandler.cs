using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Address.Commands.DeleteAddressCommand
{
    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand, Unit>
    {
        private readonly IAddressRepository _addressRepository;

        public DeleteAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var addressToDelete = await _addressRepository.GetById(request.Id);

            if (addressToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Address), request.Id);
            }

            await _addressRepository.Delete(addressToDelete);

            return Unit.Value;
        }
    }
}