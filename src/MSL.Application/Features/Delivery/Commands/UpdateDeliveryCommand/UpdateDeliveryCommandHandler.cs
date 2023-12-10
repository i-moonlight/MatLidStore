using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Delivery.Commands.UpdateDeliveryCommand
{
    public class UpdateDeliveryCommandHandler : IRequestHandler<UpdateDeliveryCommand, Unit>
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryCommandHandler(IDeliveryRepository deliveryRepository, IMapper mapper)
        {
            _deliveryRepository = deliveryRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDeliveryCommand request, CancellationToken cancellationToken)
        {
            var deliveryToUpdate = _mapper.Map<Domain.Delivery>(request);
            await _deliveryRepository.Update(deliveryToUpdate);

            return Unit.Value;
        }
    }
}