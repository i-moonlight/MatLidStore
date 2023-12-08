using MediatR;
using MLS.Application.DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Inventory.Queries.GetInventoryDetail
{
    public record GetInventoryDetailQuery(int Id) : IRequest<InventoryDetailDto>;
}
