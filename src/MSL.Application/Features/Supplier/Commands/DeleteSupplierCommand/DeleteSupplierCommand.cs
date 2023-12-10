using MediatR;

namespace MLS.Application.Features.Supplier.Commands.DeleteSupplierCommand
{
    public class DeleteSupplierCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}