using MediatR;
using MLS.Application.DTO.User;

namespace MLS.Application.Features.User.Queries.GetAllUser
{
    public record GetAllUserQuery : IRequest<List<UserDto>>;
}