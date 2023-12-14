using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Logging;
using MLS.Application.Contracts.Persistence;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Address.Commands.UpdateAddressCommand
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, Unit>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<UpdateAddressCommandHandler> _logger;

        public UpdateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper, IAppLogger<UpdateAddressCommandHandler> logger)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateAddressCommandHandlerValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                _logger.LogWarning("Validation errors in update request for {0} - {1}", nameof(Domain.Address), request.Id);
                throw new BadRequestException("Invalid address", validationResult);
            }

            var addressToUpdate = _mapper.Map<Domain.Address>(request);
            await _addressRepository.Update(addressToUpdate);

            _logger.LogInformation("Update address successfully.", request);
            return Unit.Value;
        }
    }
}