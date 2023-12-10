using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Promotion;
using MLS.Application.Exceptions;

namespace MLS.Application.Features.Promotion.Queries.GetPromotionDetail
{
    public class GetPromotionDetailQueryHandler : IRequestHandler<GetPromotionDetailQuery, PromotionDetailDto>
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly IMapper _mapper;

        public GetPromotionDetailQueryHandler(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }

        public async Task<PromotionDetailDto> Handle(GetPromotionDetailQuery request, CancellationToken cancellationToken)
        {
            var promotion = await _promotionRepository.GetById(request.Id);

            if (promotion == null)
            {
                throw new NotFoundException(nameof(Domain.Promotion), request.Id);
            }

            var data = _mapper.Map<PromotionDetailDto>(promotion);

            return data;
        }
    }
}