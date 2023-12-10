using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Return;

namespace MLS.Application.Features.Return.Queries.GetAllReturn
{
    public class GetAllReturnQueryHandler : IRequestHandler<GetAllReturnQuery, List<ReturnDto>>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;

        public GetAllReturnQueryHandler(IReturnRepository returnRepository, IMapper mapper)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
        }

        public async Task<List<ReturnDto>> Handle(GetAllReturnQuery request, CancellationToken cancellationToken)
        {
            var returns = await _returnRepository.GetAll();
            var data = _mapper.Map<List<ReturnDto>>(returns);

            return data;
        }
    }
}