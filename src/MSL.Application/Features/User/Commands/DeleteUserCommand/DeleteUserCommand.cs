using MediatR;

namespace MLS.Application.Features.User.Commands.DeleteUserCommand
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public int UserId { get; set; }
    }
}