using MediatR;
using MLS.Application.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Order.Queries.GetOrderDetail
{
    public record GetOrderDetailQuery(int Id) : IRequest<OrderDetailDto>;
}
