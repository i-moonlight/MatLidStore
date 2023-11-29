using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.CartItem.Commands.DeleteCartItemCommand
{
    public class DeleteCartItemCommand : IRequest<Unit>
    {
        public int CartItemId { get; set; }
    }
}
