using MediatR;
using MLS.Application.DTO.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Delivery.Queries.GetAllDelivery
{
    public record GetAllDeliveryQuery : IRequest<List<DeliveryDto>>;
}