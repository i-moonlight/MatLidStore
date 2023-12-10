using MediatR;
using MLS.Application.DTO.CartItem;

namespace MLS.Application.Features.CartItem.Queries.GetAllCartItem
{
    public record GetAllCartItemQuery : IRequest<List<CartItemDto>>;
}