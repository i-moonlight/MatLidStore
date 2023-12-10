using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;

namespace MLS.Application.Features.Return.Commands.CreateReturnCommand
{
    public class CreateReturnCommandHandler : IRequestHandler<CreateReturnCommand, int>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;

        public CreateReturnCommandHandler(IReturnRepository returnRepository, IMapper mapper)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateReturnCommand request, CancellationToken cancellationToken)
        {
            var returnToCreate = _mapper.Map<Domain.Return>(request);
            await _returnRepository.Create(returnToCreate);

            return returnToCreate.ReturnId;
        }
    }
}