using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Inventory.Commands.DeleteInventoryCommand
{
    public class DeleteInventoryCommand : IRequest<Unit>
    {
        public int InventoryId { get; set; }
    }
}
