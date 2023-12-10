using MediatR;
using MLS.Application.DTO.Customer;

namespace MLS.Application.Features.Customer.Queries.GetAllCustomer
{
    public record GetAllCustomerQuery : IRequest<List<CustomerDto>>;
}