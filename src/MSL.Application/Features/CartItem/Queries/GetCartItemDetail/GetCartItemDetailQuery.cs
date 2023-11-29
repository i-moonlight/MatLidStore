using MediatR;
using MLS.Application.DTO.CartItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.CartItem.Queries.GetCartItemDetail
{
    public record GetCartItemDetailQuery(int Id) : IRequest<CartItemDetailDto>;
}
