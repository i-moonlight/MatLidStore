using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Shipping.Commands.CreateShippingCommand
{
    public class CreateShippingCommandHandler : IRequestHandler<CreateShippingCommand, int>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public CreateShippingCommandHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateShippingCommand request, CancellationToken cancellationToken)
        {
            var shippingToCreate = _mapper.Map<Domain.Shipping>(request);
            await _shippingRepository.Create(shippingToCreate);

            return shippingToCreate.Id;
        }
    }
}