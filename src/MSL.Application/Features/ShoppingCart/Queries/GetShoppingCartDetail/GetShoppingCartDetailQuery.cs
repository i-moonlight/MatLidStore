using MediatR;
using MLS.Application.DTO.ShoppingCart;

namespace MLS.Application.Features.ShoppingCart.Queries.GetShoppingCartDetail
{
    public record GetShoppingCartDetailQuery(int Id) : IRequest<ShoppingCartDetailDto>;
}