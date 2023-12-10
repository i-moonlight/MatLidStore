using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Payment.Commands.DeletePaymentCommand
{
    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, Unit>
    {
        private readonly IPaymentRepository _paymentRepository;

        public DeletePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Unit> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
        {
            var paymentToDelete = await _paymentRepository.GetById(request.Id);

            if (paymentToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Payment), request.Id);
            }

            await _paymentRepository.Delete(paymentToDelete);

            return Unit.Value;
        }
    }
}