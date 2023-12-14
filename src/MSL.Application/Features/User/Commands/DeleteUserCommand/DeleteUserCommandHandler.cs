using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.User.Commands.DeleteUserCommand
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = await _userRepository.GetById(request.Id);

            if (userToDelete == null)
            {
                throw new NotFoundException(nameof(Domain.User), request.Id);
            }

            await _userRepository.Delete(userToDelete);

            return Unit.Value;
        }
    }
}