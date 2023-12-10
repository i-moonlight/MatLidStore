using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Return.Commands.UpdateReturnCommand
{
    public class UpdateReturnCommandHandler : IRequestHandler<UpdateReturnCommand, Unit>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;

        public UpdateReturnCommandHandler(IReturnRepository returnRepository, IMapper mapper)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReturnCommand request, CancellationToken cancellationToken)
        {
            var returnToUpdate = _mapper.Map<Domain.Return>(request);
            await _returnRepository.Update(returnToUpdate);

            return Unit.Value;
        }
    }
}