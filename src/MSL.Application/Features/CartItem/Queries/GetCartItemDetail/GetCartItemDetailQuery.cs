using MediatR;
using MLS.Application.DTO.CartItem;

namespace MLS.Application.Features.CartItem.Queries.GetCartItemDetail
{
    public record GetCartItemDetailQuery(int Id) : IRequest<CartItemDetailDto>;
}