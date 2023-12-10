using AutoMapper;
using MediatR;
using MLS.Application.Contracts.Persistence;
using MLS.Application.DTO.WishList;

namespace MLS.Application.Features.WishList.Queries.GetAllWishList
{
    public class GetAllWishListQueryHandler : IRequestHandler<GetAllWishListQuery, List<WishListDto>>
    {
        private readonly IWishListRepository _wishListRepository;
        private readonly IMapper _mapper;

        public GetAllWishListQueryHandler(IWishListRepository wishListRepository, IMapper mapper)
        {
            _wishListRepository = wishListRepository;
            _mapper = mapper;
        }

        public async Task<List<WishListDto>> Handle(GetAllWishListQuery request, CancellationToken cancellationToken)
        {
            var wishLists = await _wishListRepository.GetAll();
            var data = _mapper.Map<List<WishListDto>>(wishLists);

            return data;
        }
    }
}