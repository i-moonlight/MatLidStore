using MediatR;
using MLS.Application.DTO.WishList;

namespace MLS.Application.Features.WishList.Queries.GetAllWishList
{
    public record GetAllWishListQuery : IRequest<List<WishListDto>>;
}