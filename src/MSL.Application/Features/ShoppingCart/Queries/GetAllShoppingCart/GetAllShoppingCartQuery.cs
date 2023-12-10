using MediatR;
using MLS.Application.DTO.ShoppingCart;

namespace MLS.Application.Features.ShoppingCart.Queries.GetAllShoppingCart
{
    public record GetAllShoppingCartQuery : IRequest<List<ShoppingCartDto>>;
}