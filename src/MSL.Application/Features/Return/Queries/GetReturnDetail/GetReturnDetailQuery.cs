using MediatR;
using MLS.Application.DTO.Return;

namespace MLS.Application.Features.Return.Queries.GetReturnDetail
{
    public record GetReturnDetailQuery(int Id) : IRequest<ReturnDetailDto>;
}