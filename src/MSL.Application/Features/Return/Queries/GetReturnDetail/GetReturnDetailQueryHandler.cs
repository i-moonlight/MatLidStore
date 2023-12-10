using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Return;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Return.Queries.GetReturnDetail
{
    public class GetReturnDetailQueryHandler : IRequestHandler<GetReturnDetailQuery, ReturnDetailDto>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;

        public GetReturnDetailQueryHandler(IReturnRepository returnRepository, IMapper mapper)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
        }

        public async Task<ReturnDetailDto> Handle(GetReturnDetailQuery request, CancellationToken cancellationToken)
        {
            var returnDetail = await _returnRepository.GetById(request.Id);

            if (returnDetail == null)
            {
                throw new NotFoundException(nameof(Domain.Return), request.Id);
            }

            var data = _mapper.Map<ReturnDetailDto>(returnDetail);

            return data;
        }
    }
}