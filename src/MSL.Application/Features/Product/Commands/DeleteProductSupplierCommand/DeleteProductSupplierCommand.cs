using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Product.Commands.DeleteProductSupplierCommand
{
    public class DeleteProductSupplierCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
