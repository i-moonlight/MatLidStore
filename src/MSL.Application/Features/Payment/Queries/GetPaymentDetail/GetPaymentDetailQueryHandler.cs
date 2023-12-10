using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Payment;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Payment.Queries.GetPaymentDetail
{
    public class GetPaymentDetailQueryHandler : IRequestHandler<GetPaymentDetailQuery, PaymentDetailDto>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public GetPaymentDetailQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<PaymentDetailDto> Handle(GetPaymentDetailQuery request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetById(request.Id);

            if (payment == null)
            {
                throw new NotFoundException(nameof(Domain.Payment), request.Id);
            }

            var data = _mapper.Map<PaymentDetailDto>(payment);

            return data;
        }
    }
}