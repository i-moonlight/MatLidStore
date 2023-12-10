using MediatR;
using MLS.Application.DTO.Payment;

namespace MLS.Application.Features.Payment.Queries.GetPaymentDetail
{
    public record GetPaymentDetailQuery(int Id) : IRequest<PaymentDetailDto>;
}