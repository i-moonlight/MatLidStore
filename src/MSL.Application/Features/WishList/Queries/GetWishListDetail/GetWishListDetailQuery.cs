using MediatR;
using MLS.Application.DTO.WishList;

namespace MLS.Application.Features.WishList.Queries.GetWishListDetail
{
    public record GetWishListDetailQuery(int Id) : IRequest<WishListDetailDto>;
}