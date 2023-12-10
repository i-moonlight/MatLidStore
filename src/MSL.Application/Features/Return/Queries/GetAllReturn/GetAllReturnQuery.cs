using MediatR;
using MLS.Application.DTO.Return;

namespace MLS.Application.Features.Return.Queries.GetAllReturn
{
    public record GetAllReturnQuery : IRequest<List<ReturnDto>>;
}