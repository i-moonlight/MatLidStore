using MediatR;

namespace MLS.Application.Features.Return.Commands.DeleteReturnCommand
{
    public class DeleteReturnCommand : IRequest<Unit>
    {
        public int ReturnId { get; set; }
    }
}