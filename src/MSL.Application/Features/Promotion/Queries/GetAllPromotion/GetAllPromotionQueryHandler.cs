using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.Promotion;

namespace MLS.Application.Features.Promotion.Queries.GetAllPromotion
{
    public class GetAllPromotionQueryHandler : IRequestHandler<GetAllPromotionQuery, List<PromotionDto>>
    {
        private readonly IPromotionRepository _promotionRepository;
        private readonly IMapper _mapper;

        public GetAllPromotionQueryHandler(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }

        public async Task<List<PromotionDto>> Handle(GetAllPromotionQuery request, CancellationToken cancellationToken)
        {
            var promotions = await _promotionRepository.GetAll();
            var data = _mapper.Map<List<PromotionDto>>(promotions);

            return data;
        }
    }
}