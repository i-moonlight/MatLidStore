using MediatR;
using MLS.Application.DTO.Payment;

namespace MLS.Application.Features.Payment.Queries.GetAllPayment
{
    public record GetAllPaymentQuery : IRequest<List<PaymentDto>>;
}