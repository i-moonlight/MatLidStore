using MediatR;
using MLS.Application.DTO.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.Features.Payment.Queries.GetPaymentDetail
{
    public record GetPaymentDetailQuery(int Id) : IRequest<PaymentDetailDto>;
}
