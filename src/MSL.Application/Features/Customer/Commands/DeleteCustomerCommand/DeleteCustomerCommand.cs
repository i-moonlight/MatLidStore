using MediatR;

namespace MLS.Application.Features.Customer.Commands.DeleteCustomerCommand
{
    public class DeleteCustomerCommand : IRequest<Unit>
    {
        public int CustomerId { get; set; }
    }
}