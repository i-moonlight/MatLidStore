using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Shipping.Commands.UpdateShippingCommand
{
    public class UpdateShippingCommandHandler : IRequestHandler<UpdateShippingCommand, Unit>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public UpdateShippingCommandHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateShippingCommand request, CancellationToken cancellationToken)
        {
            var shippingToUpdate = _mapper.Map<Domain.Shipping>(request);
            await _shippingRepository.Update(shippingToUpdate);

            return Unit.Value;
        }
    }
}