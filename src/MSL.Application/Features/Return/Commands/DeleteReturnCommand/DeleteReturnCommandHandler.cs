using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Return.Commands.DeleteReturnCommand
{
    public class DeleteReturnCommandHandler : IRequestHandler<DeleteReturnCommand, Unit>
    {
        private readonly IReturnRepository _returnRepository;

        public DeleteReturnCommandHandler(IReturnRepository returnRepository)
        {
            _returnRepository = returnRepository;
        }

        public async Task<Unit> Handle(DeleteReturnCommand request, CancellationToken cancellationToken)
        {
            var returnToDelete = await _returnRepository.GetById(request.ReturnId);

            if (returnToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.Return), request.ReturnId);
            }

            await _returnRepository.Delete(returnToDelete);

            return Unit.Value;
        }
    }
}