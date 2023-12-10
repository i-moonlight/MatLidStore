using MediatR;
using MLS.Application.DTO.User;

namespace MLS.Application.Features.User.Queries.GetUserDetail
{
    public record GetUserDetailQuery(int Id) : IRequest<UserDetailDto>;
}