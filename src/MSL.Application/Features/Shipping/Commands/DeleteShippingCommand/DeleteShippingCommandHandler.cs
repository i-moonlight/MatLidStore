using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Shipping.Commands.DeleteShippingCommand
{
    public class DeleteShippingCommandHandler : IRequestHandler<DeleteShippingCommand, Unit>
    {
        private readonly IShippingRepository _shippingRepository;

        public DeleteShippingCommandHandler(IShippingRepository shippingRepository)
        {
            _shippingRepository = shippingRepository;
        }

        public async Task<Unit> Handle(DeleteShippingCommand request, CancellationToken cancellationToken)
        {
            var shippingToDelete = await _shippingRepository.GetById(request.Id);

            if (shippingToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Shipping), request.Id);
            }

            await _shippingRepository.Delete(shippingToDelete);

            return Unit.Value;
        }
    }
}