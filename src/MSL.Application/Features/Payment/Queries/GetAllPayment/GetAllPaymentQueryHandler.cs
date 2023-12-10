using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Payment;

namespace MLS.Application.Features.Payment.Queries.GetAllPayment
{
    public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQuery, List<PaymentDto>>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public GetAllPaymentQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<List<PaymentDto>> Handle(GetAllPaymentQuery request, CancellationToken cancellationToken)
        {
            var payments = await _paymentRepository.GetAll();
            var data = _mapper.Map<List<PaymentDto>>(payments);

            return data;
        }
    }
}