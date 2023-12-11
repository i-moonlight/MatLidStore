using MediatR;
using MLS.Application.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetAllOrderHistory
{
    public record GetAllOrderHistoryQuery : IRequest<List<OrderHistoryDto>>;
}
