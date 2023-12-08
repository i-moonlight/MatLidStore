using MediatR;
using MLS.Application.DTO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Customer.Queries.GetCustomerDetail
{
    public record GetCustomerDetailQuery(int Id) : IRequest<CustomerDetailDto>;
}