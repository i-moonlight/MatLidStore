using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Logging;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Address.Commands.CreateAddressCommand
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<CreateAddressCommandHandler> _logger;

        public CreateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper, IAppLogger<CreateAddressCommandHandler> logger)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateAddressCommandHandlerValidator();
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);

            if (validatorResult.Errors.Any())
            {
                throw new BadRequestException("Invalid Address", validatorResult);
            }

            var addressToCreate = _mapper.Map<Domain.Address>(request);
            await _addressRepository.Create(addressToCreate);

            _logger.LogInformation("Created address successfully.");
            return addressToCreate.Id;
        }
    }
}