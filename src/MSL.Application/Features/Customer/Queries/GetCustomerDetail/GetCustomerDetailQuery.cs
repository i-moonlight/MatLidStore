using MediatR;
using MLS.Application.DTO.Customer;

namespace MLS.Application.Features.Customer.Queries.GetCustomerDetail
{
    public record GetCustomerDetailQuery(int Id) : IRequest<CustomerDetailDto>;
}